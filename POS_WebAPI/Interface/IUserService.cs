using POS_WebAPI.Models.RequestModel.User;
using POS_WebAPI.Models.Response;

namespace POS_WebAPI.Interface
{
    public interface IUserService : IService<UserResponse, UserCreateReq, UserUpdateReq>
    {
        Response<UserResponse?> GetLogin(UserLoginReq request);
    }
}
