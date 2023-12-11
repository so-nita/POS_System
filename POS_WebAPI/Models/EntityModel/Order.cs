using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.EntityModel
{
    public class Order 
    {
        public string Id { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public int TotalItem { get; set; }
        public decimal Total { get; set; }  
        public OrderStatus OrderStatus { get; set; }  
        public string User_Id { get; set; } = null!;
        public string? Customer_Id { get; set; }  
        public string? Table_Id { get; set;}
        public DateTime Create_At { get; set; }
        public bool? Is_Delete { get; set; }

        // Navigate association
        public Table? Table { get; set; } 
        public Customer? Customer { get; set; }
        public User User { get; set; } = null!;
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
