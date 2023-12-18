using POS_WebAPI.Interface;
using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.RequestModel.User
{
    public class UserResponse : IResponse
    {
        public string Id { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = "";
        public string Name { get; set; } = null!;
        public Gender Gender { get; set; }
        public string? Email { get; set; } = "";
        public string Contact { get; set; } = "";
        public string? Image { get; set; }
        public string Company_Id { get; set; } = "";
        public string Role_Id { get; set; } = "";
        public string Role_Type { get; set; } = "";
        public string? Address { get; set; }
        public DateTime Create_At { get; set; }
        public Status Status { get; set; }
        public bool? Is_Deleted { get; set; }
        public string? Token { get; set; }
    }
}
