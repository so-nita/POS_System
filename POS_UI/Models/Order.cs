using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_UI.Model
{
    public class OrderReq
    {
        public DateTime OrderDate { get; set; }
        public decimal SubTotal { get; set; } = 0.00m;
        public decimal? Discount { get; set; } = 0.00m;
        public string? DiscountType { get; set; }  
        public decimal TotalKhr { get; set; }
        public decimal Tax { get; set; } = 10;
        public decimal Total { get; set; } = 0.00m;
        public decimal Received { get; set; } = 0.00m;
        public decimal? Remain { get;set; }
        public List<OrderDetailReq> OrderDetails { get; set; }= new();
    }
}
