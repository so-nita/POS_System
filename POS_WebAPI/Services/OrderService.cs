using Microsoft.EntityFrameworkCore;
using POS_WebAPI.DataValidation;
using POS_WebAPI.Interface;
using POS_WebAPI.Models;
using POS_WebAPI.Models.EntityModel;
using POS_WebAPI.Models.RequestModel.Order;
using POS_WebAPI.Models.Response;

namespace POS_WebAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _repo;
        private readonly IRepository<OrderDetail> _repoDetail;
        public readonly IRepository<Product> _repoProduct;
        public readonly IRepository<User> _repoUser;

        public OrderService(IRepository<Order> repo, IRepository<Product> repoProduct, IRepository<OrderDetail> repoDetail, IRepository<User> repoUser)
        {
            _repo = repo;
            _repoProduct = repoProduct;
            _repoDetail = repoDetail;
            _repoUser = repoUser;
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
                            Discount_Amount = discount,
                            Product_Name = product.Name,
                            Price = product.Price,
                            Qty = item.Qty,
                            Size = product.Size,
                            Sub_Amount = item.Qty * product.Price,
                            Grand_Amount = item.Qty * product.Price,
                            Create_At = DateTime.Now,
                        };
                        product.Qty -= item.Qty;

                        orderDetails.Add(orderDetail);
                        productSell.Add(product);
                    }
                }
                var subtotal = orderDetails.Sum(e => e.Grand_Amount);
                var taxAmount = subtotal * request.Tax / 100;
                var order = new Order()
                {
                    Id = orderId,
                    Tax = taxAmount,
                    Reference_Id = request.User_Id,
                    Company_Id = user.Company.Id,
                    Source_Id = request.Source_Id,
                    Sub_Total = subtotal,
                    Total_Discount = orderDetails.Sum(e => e.Discount_Amount ?? 0),
                    Grand_Total = subtotal + taxAmount,
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
                        Reference_Name = e.User.Name,
                        Source_Id = e.Source_Id,
                        Source_Name = e.Source.Name,
                        Sub_Total = e.Sub_Total,
                        Tax = e.Tax ?? 0,
                        Total_Discount = e.Total_Discount,
                        Grand_Total = e.Grand_Total,
                        Is_Delete = e.Is_Delete,
                        OrderDetails = e.OrderDetails.Select(e => new OrderDetailResponse()
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

        public Response<string> Update(OrderUpdateReq req)
        {
            try
            {
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
                return _repo.SaveChanges() > 0 ? Response<string>.Success() : Response<string>.Fail();
            }
            catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }


    }
}
