using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.EntityModel
{
    public class UserLog
    {
        public string Id { get; set; } = "";
        public string User_Id { get; set; } = "";
        public string User_Name { get; set; } = "";
        public string User_Type { get; set; } = "";
        public ActionLog Action { get; set; }  
        public DateTime Create_At { get; set; } 
        //
        public User User { get; set; } = null!;
        //public ICollection<Product>? Products { get; set; }
    }
}


