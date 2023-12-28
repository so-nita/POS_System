using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.EntityModel
{
    public class Order 
    {
        public string Id { get; set; } = null!;
        public decimal Sub_Total { get; set; }
        public decimal Total_Discount { get; set; }
        public decimal Grand_Total { get; set; }
        public string Source_Id { get; set;}=null!;
        public string Reference_Id { get; set; } = null!;
        public string Company_Id { get; set; } = null!;
        public decimal? Tax { get; set; } = 0;
        public DateTime Order_Date { get; set; }
        public OrderStatus Order_Status { get; set; }
        public bool? Is_Delete { get; set; }

        // Navigate association
        public ICollection<Receipt>? Receipts { get; set; }
        public User? User { get; set; } = null!;
        public ICollection<OrderDetail>? OrderDetails { get; set; }
        public Source? Source { get; set; }
    }
}
