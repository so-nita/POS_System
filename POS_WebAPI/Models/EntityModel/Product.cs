using POS_WebAPI.Interface;
using POS_WebAPI.Models.Constant;
using System.IO.Pipes;

namespace POS_WebAPI.Models.EntityModel
{
    public class Product  
    {
        public string Id { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? NameKh { get; set; } = null!;
        public string Company_Id { get; set; } = null!;
        public string Category_Id { get; set; } = null!;
        public string? Image { get; set; } = null!;
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public DateTime Create_At { get; set; }
        public Status Status { get; set; }
        public bool Is_Deleted { get; set; }
        //
        public ICollection<OrderDetail>? OrderDetails { get; set; }
        public Company Company { get; set; } = null!;
        public SubCategory SubCategory { get; set; } = null!;
    }
}