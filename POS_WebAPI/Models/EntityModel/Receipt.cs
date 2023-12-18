using POS_WebAPI.Models.Constant;
using System.Security.Permissions;

namespace POS_WebAPI.Models.EntityModel
{
    public class Receipt
    {
        public string Id { get; set; } = "";
        public string Order_Id { get; set; } = "";
        public decimal Grand_Total { get; set; }  
        public decimal? Discount { get; set; }
        public string? Discoun_Type { get; set; }
        public decimal Total { get; set; }
        public string Reference { get; set; } = "";
        public DateTime Transaction_Date { get; set; }
        //
        public Order Order { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
