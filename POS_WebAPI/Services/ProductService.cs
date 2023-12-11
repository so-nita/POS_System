using Microsoft.EntityFrameworkCore;
using POS_WebAPI.DataContext;
using POS_WebAPI.Interface.Product;
using POS_WebAPI.Models;
using POS_WebAPI.Models.EntityModel;
using POS_WebAPI.Models.RequestModel.Product;
using POS_WebAPI.Models.Response;
using POS_WebAPI.Repository;

namespace POS_WebAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repo;
        public ProductService(IRepository<Product> repo)
        {
            _repo = repo ?? throw new Exception();
        }
        
        private Response<List<ProductResponse>>? GetAll()
        {
            try
            {
                var data = _repo.GetQueryable()
                        .Include(e=>e.Company).Include(c=>c.SubCategory)
                        .Select(e => new ProductResponse()
                        {
                            Id = e.Id,
                            Name = e.Name,
                            NameKh = e.NameKh,
                            Image = e.Image,
                            Price = e.Price,
                            Cost = e.Cost,
                            Code = e.Code,
                            Company_Id = e.Company_Id,
                            Company_Name = e.Company.Name,
                            Sub_Category_Id = e.Category_Id,
                            Sub_Category_Name = e.SubCategory.Name,
                            Create_At = e.Create_At,
                            Status = e.Status,
                            Description = e.Description,
                            Is_Deleted = e.Is_Deleted
                        }).ToList();

                return Response<List<ProductResponse>>.Success(data, data.Count());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Response<List<ProductResponse>>.Fail();
            }
        }
        public Response<ProductResponse> Read(Key key)
        {
            try
            {
                var product = GetAll().Result!.Where(e=> e.Id==key.Id && e.Is_Deleted == false).First();
                if (product == null)
                {
                    return Response<ProductResponse>.NotFound();
                }
                
                return Response<ProductResponse>.Success(product);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Response<ProductResponse>.Fail();
            }
        }

        public Response<List<ProductResponse>> ReadAll()
        {
            try
            {
                var test = _repo.GetAll();
                var products = GetAll().Result!.Where(e => e.Is_Deleted == false).ToList();
                return Response<List<ProductResponse>>.Success(products,products.Count());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Response<List<ProductResponse>>.Fail();
            }
        }

        public Response<string> Create(ProductCreateReq req)
        {
            throw new NotImplementedException();
        }

        public Response<string> Update(ProductUpdateReq req)
        {
            try
            {
                var found = _repo.GetById(req.Id);
                if(found == null)   return Response<string>.Fail();

                found.Code = req.Code!;
                _repo.Update(found);
                return Response<string>.Fail("Update Successfully.");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
                return Response<string>.Fail("Fail to update.");
            }
        }

        public Response<string> Delete(Key key)
        {
            try
            {
                var found = _repo.GetById(key.Id);
                if(found == null)   return Response<string>.NotFound("Product not found.");
                
                found.Is_Deleted = true;
                _repo.Update(found);
                return Response<string>.Fail("Failed to update.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Response<string>.Fail("Failed to update.");
            }
        }

        
    }
}
