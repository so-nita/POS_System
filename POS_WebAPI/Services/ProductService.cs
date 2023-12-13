using AutoMapper;
using Microsoft.EntityFrameworkCore;
using POS_WebAPI.DataContext;
using POS_WebAPI.DataValidation;
using POS_WebAPI.Interface.Product;
using POS_WebAPI.Models;
using POS_WebAPI.Models.EntityModel;
using POS_WebAPI.Models.RequestModel.Category;
using POS_WebAPI.Models.RequestModel.Product;
using POS_WebAPI.Models.Response;
using POS_WebAPI.Repository;
using System.Security.Cryptography.Xml;

namespace POS_WebAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repo;
        private readonly IRepository<Company> _repoCompany;
        private readonly IRepository<SubCategory> _repoSubCate;
        private readonly IMapper _mapper;
        public ProductService(IRepository<Product> repo, IRepository<Company> company, IRepository<SubCategory> subcategory,IMapper mapper)
        {
            _repo = repo;
            _repoCompany = company;
            _repoSubCate = subcategory;
            _mapper = mapper;
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
                            Status = e.Status.ToString(),
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
            try
            {
                var dataErrors = DataValidation<ProductCreateReq>.ValidateDynamicTypes(req);
                if (dataErrors.Count > 0)
                {
                    return Response<string>.Fail(data: dataErrors.First().ToString());
                }
                var existProduct = _repo.GetQueryable().Where(e => e.Is_Deleted.Equals(false));

                var existCode = existProduct.FirstOrDefault(e => e.Code == req.Code);
                if (existCode != null)   return Response<string>.Conflict($"Code {req.Code} is existing.");

                var checkCompany = _repoCompany.GetQueryable().FirstOrDefault(e => e.Id == req.Company_Id && e.Is_Deleted.Equals(false));
                if (checkCompany == null) return Response<string>.Conflict($"Company Id '{req.Company_Id}' does not existing.");

                var checkCategory = _repoSubCate.GetQueryable().FirstOrDefault(e => e.Id == req.Category_Id && e.Is_Deleted.Equals(false));
                if (checkCompany == null) return Response<string>.Conflict($"Category Id '{req.Category_Id}' does not existing.");

                var product = new Product()
                {
                    Id = Guid.NewGuid().ToString(),
                    Code = req.Code,
                    Name = req.Name,
                    NameKh = req.NameKh,
                    Company_Id = req.Company_Id,
                    Category_Id = req.Category_Id,
                    Cost = req.Cost,
                    Price = req.Price,
                    Image = req.Image,
                    Status = req.Status,
                    Description = req.Description,
                    Create_At = DateTime.Now,
                    Is_Deleted = false
                };

                _repo.Add(product);
               ;

                return _repo.SaveChanges()>0 ? Response<string>.Fail("Create Successfully.")
                                             : Response<string>.Fail("Fail to Create.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Response<string>.Fail("Fail to Create.");
            }
        }

        public Response<string> Update(ProductUpdateReq req)
        {
            try
            {
                var productFound = _repo.GetById(req.Id);
                if(productFound == null)   return Response<string>.Fail($"Product Id : {req.Id} not found.");

                var data = _mapper.Map(req, productFound);

                _repo.Update(data);
                return _repo.SaveChanges() > 0 ? Response<string>.Success("Updated Successfully.") 
                                               : Response<string>.Fail("Failed to update.");
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
                //_repo.Delete(found);

                return _repo.SaveChanges() > 0 ? Response<string>.Success("Deleted Successfully.") 
                                               : Response<string>.Fail("Failed to delete.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Response<string>.Fail(ex.Message);
            }
        }

        
    }
}
