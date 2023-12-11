
namespace POS_WebAPI.Models.EntityModel
{
    public class OrderDetail
    {
        public string Id { get; set; } = null!;
        public string Product_Id { get; set; } = "";

        public string Order_Id { get; set; }    = string.Empty;
        public string Product_Name { get; set;} = string.Empty;
        public string Size { get; set;} = string.Empty;
        public decimal Price { get; set;}
        public int Qty { get; set;}
       // public decimal Discount { get; set;}
        public decimal GrandTotal { get; set;}
        public decimal Tax { get; set;} 
        public decimal Total { get; set;}
        public DateTime Create_At { get; set; }
        // 
        public Order Order { get; set; } = null!;
        public Product Product { get; set; }=null!;
    }
}
