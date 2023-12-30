using POS_WebAPI.Interface;
using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.RequestModel.Order;

public class OrderCreateReq : ICreateReq
{
    public decimal Tax { get; set; }         
    public string User_Id { get; set; } = "";
    public string Source_Id { get; set; } = "";
    public OrderStatus Order_Status { get; set; }
    public List<OrderDetailCreateReq> OrderDetails { get; set; } = new ();
}

public class OrderDetailCreateReq
{
    public string Product_Id { get; set; } = "";
    public decimal? Discount_Percent { get; set; }
    public int Qty { get; set; }    
}