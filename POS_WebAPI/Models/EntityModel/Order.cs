using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.EntityModel
{
    public class Order 
    {
        public string Id { get; set; } = null!;
        public int Total_Item { get; set; }
        public decimal Grand_Total { get; set; }
        public decimal Total_Discount { get; set; }
        public decimal Total { get; set; }  
        public string User_Id { get; set; } = null!;
        public string Company_Id { get; set; }=null!;
        public string Section_Id { get; set;}=null!;
        public string Reference_Id { get; set; }=null!;
        public DateTime Order_Date { get; set; }
        public OrderStatus Order_Status { get; set; }
        public DateTime Create_At { get; set; }
        public bool? Is_Delete { get; set; }

        // Navigate association
        public ICollection<Receipt>? Receipts { get; set; }
        public User? User { get; set; } = null!;
        public ICollection<OrderDetail>? OrderDetails { get; set; }
        public Section? Section { get; set; }
    }
}
