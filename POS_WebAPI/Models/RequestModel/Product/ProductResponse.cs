using POS_WebAPI.Interface;
using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.RequestModel.Product
{
    public class ProductResponse : IResponse
    {
        public string Id { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? NameKh { get; set; }
        public string Company_Id { get; set; }= null!;
        public string Company_Name { get; set; } = null!;
        public string Sub_Category_Id { get; set; } = null!;
        public string Sub_Category_Name { get; set; } = null!;
        public string? Image { get; set; }  
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public DateTime Create_At { get; set; }
        public string Status { get; set; }=null!;
        public bool Is_Deleted { get; set; }
    }
}
