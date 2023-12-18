using POS_WebAPI.Interface;
using POS_WebAPI.Models;
using POS_WebAPI.Models.EntityModel;
using POS_WebAPI.Models.RequestModel.User;
using POS_WebAPI.Models.Response;

namespace POS_WebAPI.Services
{
    public class UserService : IUserService
    {
        public readonly IRepository<User> _repo;

        public UserService(IRepository<User> repository)
        {
            _repo = repository;
        }


        public Response<string> Create(UserCreateReq req)
        {
            try
            {
                return Response<string>.Success();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public Response<UserResponse?> Read(Key key) 
        {
            try
            {
                return Response<UserResponse>.Success();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public Response<List<UserResponse>>? ReadAll()
        {
            try
            {
                return Response<List<UserResponse>>.Success();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
        private Response<List<UserResponse>>? GetAll()
        {
            try
            {
                var data = _repo.GetQueryable().Select(e => new UserResponse()
                {
                    Id = e.Id,
                    Name = e.Name,
                    UserName = e.UserName,
                    Password = e.Password,
                    Address = e.Address,
                    Company_Id = e.Company_Id,
                    Role_Id = e.Role_Id,
                    Role_Type = e.Role.Name,
                    Is_Deleted = e.Is_Deleted
                }).ToList();
                return Response<List<UserResponse>>.Success(data);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public Response<UserResponse?> GetLogin(UserLoginReq request)
        {
            try
            {
                var data =  GetAll().Result!
                    .FirstOrDefault(e=>e.UserName.ToLower() == request.Username.ToLower()
                    && e.Password == request.Password && e.Is_Deleted==false);
                if(data == null)
                {
                    return Response<UserResponse?>.NotFound();
                }
                return Response<UserResponse?>.Success(data);
            }catch (Exception ex)
            {
                throw ex;
            }
        }
        public Response<string> Update(UserUpdateReq req)
        {
            try
            {
                return Response<string>.Success();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
        public Response<string> Delete(Key key)
        {
            try
            {
                return Response<string>.Success();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

       
    }
}
