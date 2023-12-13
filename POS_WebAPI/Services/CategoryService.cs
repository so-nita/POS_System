using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using POS_WebAPI.DataValidation;
using POS_WebAPI.Interface;
using POS_WebAPI.Interface.ICategory;
using POS_WebAPI.Models;
using POS_WebAPI.Models.EntityModel;
using POS_WebAPI.Models.RequestModel.Category;
using POS_WebAPI.Models.Response;
using POS_WebAPI.Repository;

namespace POS_WebAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _repo;
        private readonly IMapper _mapper;
        public CategoryService(IRepository<Category> repository,IMapper mapper) 
        { 
            _repo = repository;
            _mapper = mapper;
        }

        private Response<IEnumerable<CategoryResponse?>> GetAll()
        {
            try
            {
                var data = _repo.GetAll().Select(e => new CategoryResponse()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Image = e.Image,
                    Status = e.Status,
                    Description = e.Description,
                    Create_At = DateTime.Now,
                    Is_Deleted = e.Is_Deleted,
                }).ToList();
                return Response<IEnumerable<CategoryResponse?>>.Success(data);
            }
            catch (Exception ex)
            {
                return Response<IEnumerable<CategoryResponse?>>.Fail();
            }
        }
        public Response<string> Create(CategoryCreateReq req)
        {
            try
            {
                var dataErrors = DataValidation<CategoryCreateReq>.ValidateDynamicTypes(req); 
                if (dataErrors.Count > 0)
                {
                    return Response<string>.Fail(data: dataErrors.First().ToString());
                }
                var category = new Category()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = req.Name,
                    Image = req.Image,
                    Status = req.Status,
                    Description = req.Description,
                    Create_At = DateTime.Now,
                    Is_Deleted = false,
                };

                _repo.Add(category);
                _repo.SaveChanges();

                return Response<string>.Success("Create Successfully");
            }
            catch (Exception ex)
            {
                return Response<string>.Fail(ex.Message);
            }
        }
        public Response<CategoryResponse?> Read(Key key)
        {
            var data = GetAll().Result!.FirstOrDefault(e =>e.Id==key.Id && e.Is_Deleted == false);

            return Response<CategoryResponse?>.Success(data!);
        }

        public Response<List<CategoryResponse>>? ReadAll()
        {
            try
            {
                var data = GetAll().Result!.Where(e=>e.Is_Deleted==false).ToList();

                return Response<List<CategoryResponse>>.Success(data!,data.Count());
            }
            catch (Exception ex)
            {
                return Response<List<CategoryResponse>>.Fail();
            }
        }
        
        public Response<string> Update(CategoryUpdateReq req)
        {
            try
            {
                if (req.Id == null)
                {
                    return Response<string>.NotFound("Field Id is required.");
                }
                var category = _repo.GetQueryable().FirstOrDefault(e => e.Id == req.Id && e.Is_Deleted == false);
                if (category == null) return Response<string>.NotFound("Category not found.");

                var data = _mapper.Map(req, category);

                _repo.Update(data);
                return _repo.SaveChanges() > 0 ? Response<string>.Success("Update Successfully.") 
                                               : Response<string>.Fail("Faild to Update.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);    
            }
        }
        public Response<string> Delete(Key key)
        {
            try
            {
                var found = _repo.GetById(key.Id);
                if (found == null) return Response<string>.NotFound("Category not found.");

                found.Is_Deleted = true;
                _repo.Update(found);

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
