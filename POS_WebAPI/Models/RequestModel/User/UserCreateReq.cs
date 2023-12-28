using POS_WebAPI.Interface;
using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.RequestModel.User;

public class UserCreateReq : ICreateReq
{
    public string UserName { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Company_Id { get; set; } = "";
    public string Role_Id { get; set; } = "";
    public Gender? Gender { get; set; }
    public string? Email { get; set; } = "";
    public string Password { get; set; } = "";
    public string Contact { get; set; } = "";
    public string? Image { get; set; }
    public string? Address { get; set; }
    //public Status Status { get; set; }
}
