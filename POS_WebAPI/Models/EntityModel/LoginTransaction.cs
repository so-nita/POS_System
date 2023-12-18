namespace POS_WebAPI.Models.EntityModel
{
    public class LoginTransaction
    {
        public string Id { get; set; } = "";
        public string User_Id { get; set; } = "";
        public string User_Name { get; set; } = "";
        public DateTime Login_At { get; set; }
        public DateTime Logout_At { get; set; } 
        //
        public User User { get; set; } = null!;
    }
}


