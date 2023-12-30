using AutoMapper;
using Microsoft.EntityFrameworkCore;
using POS_WebAPI.DataValidation;
using POS_WebAPI.Interface;
using POS_WebAPI.Interface.Product;
using POS_WebAPI.Models;
using POS_WebAPI.Models.Constant;
using POS_WebAPI.Models.EntityModel;
using POS_WebAPI.Models.RequestModel.Product;
using POS_WebAPI.Models.Response;

namespace POS_WebAPI.Services;

public class ProductService : IProductService
{
    private readonly IRepository<Product> _repo;
    private readonly IRepository<SubCategory> _repoSubCate;
    private readonly IRepository<User> _repoUser;
    private readonly IMapper _mapper;
    public ProductService(IRepository<Product> repo, IRepository<SubCategory> subcategory, IMapper mapper, IRepository<User> repoUser)
    {
        _repo = repo;
        _repoSubCate = subcategory;
        _mapper = mapper;
        _repoUser = repoUser;
    }

    private Response<List<ProductResponse>>? GetAll()
    {
        try
        {
            var data = _repo.GetQueryable()
                    .Include(c=>c.SubCategory)
                    .Include(e=>e.User)
                    .Select(e => new ProductResponse()
                    {
                        Id = e.Id,
                        Name = e.Name,
                        NameKh = e.NameKh,
                        Image = e.Image,
                        Price = e.Price,
                        Cost = e.Cost,
                        Code = e.Code,
                        Qty = e.Qty,
                        Create_By = e.Create_By,
                        Create_By_Name = e.User.Name,
                        Company_Id = e.Company_Id,
                        Company_Name = e.Company_Name,
                        Sub_Category_Id = e.Category_Id,
                        Sub_Category_Name = e.SubCategory.Name,
                        Create_At = e.Create_At,
                        Status = e.Status.ToString(),
                        Description = e.Description,
                        Is_Deleted = e.Is_Deleted,
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
            var product = GetAll()!.Result!.Where(e=> e.Id==key.Id && e.Is_Deleted == false).First();
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
            var products = GetAll().Result!.Where(e => e.Is_Deleted == false).ToList();

            return Response<List<ProductResponse>>.Success(products,products.Count());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return Response<List<ProductResponse>>.Fail();
        }
    }

    public Response<string> Create(ProductCreateReq request)
    {
        try
        {
            var dataErrors = DataValidation<ProductCreateReq>.ValidateDynamicTypes(request);
            if (dataErrors.Count > 0)
            {
                return Response<string>.Fail(data: dataErrors.First().ToString());
            }
            var existProduct = _repo.GetQueryable().Where(e => e.Is_Deleted.Equals(false));

            var existCode = existProduct.FirstOrDefault(e => e.Code == request.Code);
            if (existCode != null)   
                return Response<string>.Conflict($"Code {request.Code} is existing.");

            var user = _repoUser.GetQueryable().Include(e=>e.Company)
                                .FirstOrDefault(e => e.Id == request.Create_By && e.Is_Deleted.Equals(false));

            if (user == null) 
                return Response<string>.Conflict($"User Id '{request.Create_By}' does not existing.");

            var checkCategory = _repoSubCate.GetById(request.Category_Id);

            if (checkCategory == null) 
                return Response<string>.Conflict($"Category Id '{request.Category_Id}' does not existing.");

            if(request.Price <= request.Cost)
            {
                return Response<string>.Fail($"Price must be more than Cost {request.Cost}");
            }

            var product = new Product()
            {
                Id = Guid.NewGuid().ToString(),
                Code = request.Code,
                Name = request.Name,
                NameKh = request.NameKh,
                Company_Id = user.Company_Id,
                Company_Name = user.Company.Name,
                Create_By = user.Id,
                Qty = 0,
                Category_Id = request.Category_Id,
                Cost = request.Cost,
                Price = request.Price,
                Image = request.Image,
                Description = request.Description,
                Create_At = DateTime.Now,
                Status = Status.Enable,
                Is_Deleted = false,
            };

            _repo.Add(product);
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
            data.Last_Update = DateTime.Now;

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
