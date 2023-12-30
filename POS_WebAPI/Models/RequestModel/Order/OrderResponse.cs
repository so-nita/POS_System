using POS_WebAPI.Interface;
using POS_WebAPI.Models.Constant;
using POS_WebAPI.Models.EntityModel;
using POS_WebAPI.Models.RequestModel.Order.OrderDetail;

namespace POS_WebAPI.Models.RequestModel.Order;

public class OrderResponse : IResponse
{
    public string Id { get; set; } = null!;
    public decimal Sub_Total { get; set; }
    public decimal Total_Discount { get; set; }
    public decimal Tax {  get; set; }
    public decimal Grand_Total { get; set; }
    public string Company_Id { get; set; } = null!;
    public string Company_Name { get; set; } = null!;
    public string Source_Id { get; set; } = null!;
    public string Source_Name { get; set; } = null!;
    public string Reference_Id { get; set; } = null!;
    public string Reference_Name { get; set; } = null!;
    public DateTime Order_Date { get; set; }
    public OrderStatus Order_Status { get; set; }
    public bool? Is_Delete { get; set; }
    public ICollection<OrderDetailResponse> OrderDetails { get; set; } = null!;
}