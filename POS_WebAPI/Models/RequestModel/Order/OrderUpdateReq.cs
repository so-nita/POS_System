using POS_WebAPI.Interface.IService;
using POS_WebAPI.Models.Constant;
using POS_WebAPI.Models.RequestModel.Order.OrderDetail;

namespace POS_WebAPI.Models.RequestModel.Order;

public class OrderUpdateReq : IUpdateReq
{
    public string Id { get; set; } = null!;
    public string? Source_Id { get; set; } = null!;
    /*public string Reference_Id { get; set; } = null!;*/
    public decimal? Tax { get; set; } = 0;
    public OrderStatus? Order_Status { get; set; }
    public List<OrderDetailUpdateReq> OrderDetails { get; set; } = new ();
}
