using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Interface.Product
{
    public class ProductCreateReq : ICreateReq
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? NameKh { get; set; }  
        public string Company_Id { get; set; } = null!;
        public string Category_Id { get; set; } = null!;
        public string? Image { get; set; }  
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public Status Status { get; set; }
        public string? Description { get; set; }
    }
}