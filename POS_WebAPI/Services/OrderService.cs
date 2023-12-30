using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using POS_WebAPI.DataValidation;
using POS_WebAPI.Interface;
using POS_WebAPI.Models;
using POS_WebAPI.Models.EntityModel;
using POS_WebAPI.Models.RequestModel.Order;
using POS_WebAPI.Models.RequestModel.Order.OrderDetail;
using POS_WebAPI.Models.Response;

namespace POS_WebAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _repo;
        private readonly IRepository<OrderDetail> _repoDetail;
        public readonly IRepository<Product> _repoProduct;
        public readonly IRepository<User> _repoUser;
        public readonly IMapper _mapper;
        public OrderService(IRepository<Order> repo, IRepository<Product> repoProduct, IRepository<OrderDetail> repoDetail, IRepository<User> repoUser,IMapper mapper)
        {
            _repo = repo;
            _repoProduct = repoProduct;
            _repoDetail = repoDetail;
            _repoUser = repoUser;
            _mapper = mapper;
        }

        public Response<string> Create(OrderCreateReq request)
        {
            try
            {
                var dataErrors = DataValidation<OrderCreateReq>.ValidateDynamicTypes(request);
                if (dataErrors.Count > 0)
                {
                    return Response<string>.Fail(dataErrors.First());
                }

                var user = _repoUser.GetQueryable()
                            .Where(e => e.Id == request.User_Id && e.Is_Deleted == false)
                            .Include(e => e.Company).First();

                if (user == null) return Response<string>.NotFound();

                var orderDetails = new List<OrderDetail>();
                var products = _repoProduct.GetAll();
                var orderId = Guid.NewGuid().ToString();
                var productSell = new List<Product>();

                foreach (var item in request.OrderDetails)
                {
                    var product = products.FirstOrDefault(e => e.Id == item.Product_Id);

                    if (product != null)
                    {
                        var discount = product.Price * item.Discount_Percent / 100;
                        var orderDetail = new OrderDetail()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Order_Id = orderId,
                            Product_Id = product.Id,
                            Discount_Percent = item.Discount_Percent,
                            Discount_Amount = discount * item.Qty,
                            Product_Name = product.Name,
                            Price = product.Price,
                            Qty = item.Qty,
                            Size = product.Size,
                            Sub_Amount = item.Qty * product.Price,
                            Grand_Amount = (item.Qty * product.Price) - discount??0,
                            Create_At = DateTime.Now,
                        };
                        product.Qty -= item.Qty;

                        orderDetails.Add(orderDetail);
                        productSell.Add(product);
                    }
                }
                var subtotal = orderDetails.Sum(e => e.Grand_Amount);
                var taxAmount = subtotal * request.Tax / 100;
                var totalDiscount = orderDetails.Sum(e => e.Discount_Amount ?? 0);
                var order = new Order()
                {
                    Id = orderId,
                    Tax = request.Tax,
                    Reference_Id = request.User_Id,
                    Company_Id = user.Company.Id,
                    Source_Id = request.Source_Id,
                    Sub_Total = subtotal,
                    Total_Discount = totalDiscount,
                    Grand_Total = subtotal + taxAmount​ - totalDiscount,
                    Order_Status = request.Order_Status,
                    Is_Delete = false,
                    Order_Date = orderDetails.Last().Create_At,
                };

                _repo.Add(order);
                _repoDetail.AddRange(orderDetails);

                _repoProduct.UpdateRange(productSell);

                return _repo.SaveChanges() > 0 ? Response<string>.Success(string.Empty)
                                               : Response<string>.Fail();
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        private Response<List<OrderResponse>>? GetAll()
        {
            try
            {
                var order = _repo.GetQueryable()
                    .Include(e => e.OrderDetails)
                    .Select(e => new OrderResponse()
                    {
                        Id = e.Id,
                        Company_Id = e.Company_Id,
                        Order_Date = e.Order_Date,
                        Order_Status = e.Order_Status,
                        Reference_Id = e.Reference_Id,
                        Reference_Name = e.User!.Name,
                        Source_Id = e.Source_Id,
                        Source_Name = e.Source!.Name,
                        Sub_Total = e.Sub_Total,
                        Tax = e.Tax ?? 0,
                        Total_Discount = e.Total_Discount,
                        Grand_Total = e.Grand_Total,
                        Is_Delete = e.Is_Delete,
                        OrderDetails = e.OrderDetails!.Select(e => new OrderDetailResponse()
                        {
                            Id = e.Id,
                            Product_Id = e.Product_Id,
                            Product_Name = e.Product_Name,
                            Size = e.Size,
                            Price = e.Price,
                            Qty = e.Qty,
                            Discount_Percent = e.Discount_Percent,
                            Discount_Amount = e.Discount_Amount,
                            Sub_Amount = e.Sub_Amount,
                            Grand_Amount = e.Grand_Amount,
                            Create_At = e.Create_At
                        }).ToList()
                    }).ToList();

                return Response<List<OrderResponse>>.Success(order, order.Count());
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }
        public Response<OrderResponse?> Read(Key key)
        {
            try
            {
                var order = GetAll()!.Result!.FirstOrDefault(e => e.Id == key.Id);

                return Response<OrderResponse?>.Success(order);
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<List<OrderResponse>?> ReadAll()
        {
            try
            {
                var order = GetAll()!.Result!.Where(e => e.Is_Delete == false).ToList();

                return Response<List<OrderResponse>?>.Success(order, order.Count);
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        /*public Response<string> Update(OrderUpdateReq request)
        {
            try
            {
                var order = _repo.GetById(request.Id);
                if(order == null)
                {
                    return Response<string>.NotFound();
                }
                var orderDetails = new List<OrderDetail>();
                var products = _repoProduct.GetQueryable();

                foreach (var item in request.OrderDeatails)
                {
                    var product = products.FirstOrDefault(e => e.Id == item.Product_Id);
                    var orderDetail = order.OrderDetails.FirstOrDefault(e => e.Id == item.Id);

                    if ( item.Product_Id != null)
                    {
                        var itemSubTotal = item.Qty * product!.Price;

                        var detailDiscount = item.Discount_Percent ?? orderDetail!.Discount_Percent;

                        orderDetail!.Qty = item.Qty.ToString()==null ? orderDetail.Qty : item.Qty;
                        orderDetail.Price = product.Price;
                        orderDetail.Size = product.Size;
                        orderDetail.Product_Name = product.Name;
                        orderDetail.Product_Id = item.Product_Id ?? orderDetail.Product_Id;
                        orderDetail.Discount_Percent = item.Discount_Percent ?? orderDetail.Discount_Percent;
                        orderDetail.Discount_Amount = (detailDiscount * itemSubTotal) / 100;
                        orderDetail.Sub_Amount = itemSubTotal;
                        orderDetail.Grand_Amount = orderDetail.Sub_Amount - orderDetail.Discount_Amount??0;

                        orderDetails.Add(orderDetail);
                    }
                    else
                    {
                        orderDetail!.Qty = item.Qty.ToString() == null ? orderDetail.Qty : item.Qty;
                        orderDetail.Sub_Amount = 
                    }
                }

                var subTotal = orderDetails.Sum(e => e.Grand_Amount);
                var discount = orderDetails.Sum(e => e.Discount_Amount);
                var tax = request.Tax ?? (order.Tax * subTotal)/100;
                
                order.Order_Status = request.Order_Status ?? order.Order_Status;
                order.Tax = request.Tax ?? order.Tax;
                order.Total_Discount = discount ?? 0;
                order.Sub_Total = subTotal;
                order.Grand_Total = subTotal + tax??0 - discount??0;   
                
                _repo.Update(order);
                _repoDetail.UpdateRange(orderDetails);

                return _repo.SaveChanges() > 0 ? Response<string>.Success() : Response<string>.Fail();
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }*/

        public Response<string> Update(OrderUpdateReq request)
        {
            try
            {
                var order = _repo.GetQueryable().Include(e => e.OrderDetails).First(e=>e.Id==request.Id);

                if (order == null)
                {
                    return Response<string>.NotFound();
                }
                var orderDetails = new List<OrderDetail>();
                var products = _repoProduct.GetQueryable();

                foreach (var item in request.OrderDetails)
                {
                    var product = products.FirstOrDefault(e => e.Id == item.Product_Id);
                    var orderDetail = _repoDetail.GetQueryable().Include(e=>e.Product).First(e=>e.Id==item.Id);

                    if (orderDetail != null)
                    {
                        if (item.Product_Id.IsNullOrEmpty())
                        {
                            var result = UpdateOrderDetail(orderDetail!, item, product!);
                            orderDetails.Add(result!);
                        }
                        else
                        {
                            var result = UpdateOrderDetail(orderDetail!, item, orderDetail!.Product);
                            orderDetails.Add(result!);
                        }
                    }
                }

                var subTotal = orderDetails.Sum(e => e.Grand_Amount);
                var discount = orderDetails.Sum(e => e.Discount_Amount);
                var tax = request.Tax ?? (order.Tax * subTotal) / 100;

                order.Order_Status = request.Order_Status ?? order.Order_Status;
                order.Tax = request.Tax ?? order.Tax;
                order.Total_Discount = discount ?? 0;
                order.Sub_Total = subTotal;
                order.Grand_Total = subTotal + tax ?? 0 - discount ?? 0;

                _repo.Update(order);
                _repoDetail.UpdateRange(orderDetails);

                return _repo.SaveChanges() > 0 ? Response<string>.Success() : Response<string>.Fail();
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        

        public Response<string> Delete(Key key)
        {
            try
            {
                //var order = 
                return _repo.SaveChanges() > 0 ? Response<string>.Success() : Response<string>.Fail();
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }
        public Response<string> Delete(OrderDeleteReq request)
        {
            try
            {
                var order = new Order();
                if(request.Id != null)
                {
                    order = _repo.GetById(request.Id);
                    if(order == null)
                    {
                        return Response<string>.NotFound($"Order id : {request.Id} not found");
                    }
                    if(order.OrderDetails != null)
                    {
                        _repoDetail.DeleteRange(order.OrderDetails);
                    }
                    _repo.Delete(order);
                }
                else if(request.OrderDetails != null)
                {
                    var orderDetail = new List<OrderDetail>();
                    var updatedOrder = new Order();

                    foreach (var item in request.OrderDetails)
                    {
                        var itemDetail = _repoDetail.GetById(item.Id!);
                        if (itemDetail == null) return Response<string>.NotFound($"Order Detail Id: {itemDetail.Id} not found");

                        orderDetail.Add(itemDetail);

                        if (orderDetail == null)
                        {
                            return Response<string>.NotFound($"Order id: {item.Id} not found");
                        }

                        order = _repo.GetById(itemDetail.Order_Id);
                        if (order == null)
                        {
                            return Response<string>.NotFound($"Order id: {itemDetail.Order_Id} not found");
                        }

                        var orderDetailToRemove = order.OrderDetails!.First(e => e.Id == itemDetail.Id);

                        order.OrderDetails!.Remove(orderDetailToRemove);
                        updatedOrder = CaculateOrder(order, order);
                    }

                    _repoDetail.DeleteRange(orderDetail);

                    _repo.Update(updatedOrder);
                
                }


                return _repo.SaveChanges() > 0 ? Response<string>.Success() : Response<string>.Fail();
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }
        private Order CaculateOrder(Order existOrder, Order newOrder)
        {
            if (existOrder != null && newOrder != null)
            {
                existOrder.Sub_Total = newOrder.OrderDetails!.Sum(e => e.Grand_Amount);
                existOrder.Total_Discount = newOrder.OrderDetails!.Sum(e => e.Discount_Amount) ?? 0;
                existOrder.Tax = newOrder.OrderDetails!.Sum(e => e.Grand_Amount * newOrder.Tax / 100) ?? 0;
                existOrder.Grand_Total = existOrder.Sub_Total + existOrder.Tax - existOrder.Total_Discount??0;

                return existOrder;   
            }

            return null!;   
        }
        private OrderDetail UpdateOrderDetail(OrderDetail existDetail, OrderDetailUpdateReq item, Product product)
        {
            var itemSubTotal = item.Qty * product.Price;
            var detailDiscount = item.Discount_Percent ?? existDetail.Discount_Percent;

            existDetail.Qty = item.Qty.ToString() == null ? existDetail.Qty : item.Qty;
            existDetail.Price = product.Price;
            existDetail.Size = product.Size;
            existDetail.Product_Name = product.Name;
            existDetail.Product_Id = item.Product_Id ?? existDetail.Product_Id;
            existDetail.Discount_Percent = item.Discount_Percent ?? existDetail.Discount_Percent;
            existDetail.Discount_Amount = (detailDiscount * itemSubTotal) / 100;
            existDetail.Sub_Amount = itemSubTotal;
            existDetail.Grand_Amount = existDetail.Sub_Amount - existDetail.Discount_Amount ?? 0;
            return existDetail;
        }
    }
}
