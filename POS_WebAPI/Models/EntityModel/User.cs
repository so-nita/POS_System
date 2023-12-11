using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.EntityModel
{
    public class User  
    {
        public string Id { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Name { get; set; }=null!;
        public Gender Gender { get; set; }
        public string? Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string Contact { get; set; } = "";
        public string? Image { get; set; }
        public string Company_Id { get; set; } = "";
        public string Role_Id { get; set; } = "";
        public string? Address { get; set; }
        public DateTime Create_At { get; set; }
        public Status Status { get; set; }
        public bool? Is_Deleted { get; set; }
        // 
        public Company Company { get; set; }=null!;
        public Role Role { get; set; } = null!;
        public ICollection<Order>? Orders { get; set; } = null!;
    }
}