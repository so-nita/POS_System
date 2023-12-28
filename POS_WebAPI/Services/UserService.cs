using Microsoft.AspNetCore.Identity;
using POS_WebAPI.DataValidation;
using POS_WebAPI.Interface;
using POS_WebAPI.Models;
using POS_WebAPI.Models.Constant;
using POS_WebAPI.Models.EntityModel;
using POS_WebAPI.Models.RequestModel.User;
using POS_WebAPI.Models.Response;

namespace POS_WebAPI.Services;

public class UserService : IUserService
{
    public readonly IRepository<User> _repo;
    public IRepository<Company> _repoCompany;
    public IRepository<Role> _repoRole;

    public UserService(IRepository<User> repository,IRepository<Company> repoCom,IRepository<Role> repoRole) 
    {
        _repo = repository;
        _repoCompany = repoCom;
        _repoRole = repoRole;
    }

    public Response<string> Create(UserCreateReq request)
    {
        try
        {
            var dataErrors = DataValidation<UserCreateReq>.ValidateDynamicTypes(request);
            if (dataErrors.Count > 0)
            {
                return Response<string>.Fail(data: dataErrors.First().ToString());
            }
            var companyId = _repoCompany.GetById(request.Company_Id);
            if(companyId == null)  return Response<string>.Fail("Company does not exiting.");

            var role = _repoRole.GetById(request.Role_Id);
            if (role == null) return Response<string>.Fail("Role does not existing.");

            var hasher = new PasswordHasher<string>();
            var passwordHash = hasher.HashPassword(request.UserName, request.Password);

            var user = new User()
            {
                Id = Guid.NewGuid().ToString(),
                Company_Id = request.Company_Id,
                Name = request.Name,
                Password = passwordHash,
                UserName = request.UserName,
                Address = request.Address,
                Contact = request.Contact,
                Email = request.Email,
                Gender = request.Gender,
                Image = request.Image,
                Role_Id = request.Role_Id,
                Status = Status.Enable,
                Create_At = DateTime.Now,
                Is_Deleted = false
            };

            _repo.Add(user);
            return _repo.SaveChanges() >0 ? Response<string>.Success("Create Successfully") 
                                          : Response<string>.Fail("Fail to create.");
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    public Response<UserResponse?> Read(Key key) 
    {
        try
        {
            return Response<UserResponse>.Success()!;
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
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
            throw ex.InnerException!;
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
            throw ex.InnerException!;
        }
    }

    public Response<UserResponse?> GetLogin(UserLoginReq request)
    {
        try
        {
            var user =  GetAll()!.Result!
                       .FirstOrDefault(e=>e.UserName.ToLower() == request.Username.ToLower() && e.Is_Deleted==false);
            if(user == null)
            {
                return Response<UserResponse?>.NotFound();
            }

            var hasher = new PasswordHasher<string>();
            var verifyResult = hasher.VerifyHashedPassword(user.UserName, user.Password, request.Password);

            if(verifyResult != PasswordVerificationResult.Success)
            {
                return Response<UserResponse?>.Fail(user);
            }
            user.Password = request.Password;
            return Response<UserResponse?>.Success(user);

        }catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }
    /*public Response<UserResponse?> GetLogin(UserLoginReq request)
    {
        try
        {
            var user = GetAll()!.Result!
                .FirstOrDefault(e => e.UserName.ToLower() == request.Username.ToLower() && e.Is_Deleted == false);

            if (user == null)
            {
                return Response<UserResponse?>.NotFound();
            }

            var hasher = new PasswordHasher<string>();
            var verifyResult = hasher.VerifyHashedPassword(user.UserName, user.Password, request.Password);

            if (verifyResult == PasswordVerificationResult.SuccessRehashNeeded)
            {
                var updatedHash = hasher.HashPassword(user.UserName, request.Password);

                UpdatePasswordHashInDatabase(user.Id, updatedHash);

                return Response<UserResponse?>.Success(user);
            }
            else if (verifyResult == PasswordVerificationResult.Success)
            {
                return Response<UserResponse?>.Success(user);
            }
            return Response<UserResponse?>.Success(user);
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }*/

    private void UpdatePasswordHashInDatabase(string userId, string updatedHash)
    {
        var userToUpdate = _repo.GetById(userId);
        if (userToUpdate != null)
        {
            userToUpdate.Password = updatedHash;
            _repo.Update(userToUpdate);
            _repo.SaveChanges();
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
            throw ex.InnerException!;
        }
    }

    public Response<string> Delete(Key key)
    {
        try
        {
            if(key == null) return Response<string>.Fail("Id required.");
            var user = _repo.GetById(key.Id);
            if (user == null) return Response<string>.Fail("User not found.");

            _repo.Delete(user);
            return _repo.SaveChanges()>0 ? Response<string>.Success() : Response<string>.Fail("Fail to delete.");
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }
}
