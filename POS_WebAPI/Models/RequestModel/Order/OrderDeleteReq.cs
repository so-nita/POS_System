using POS_WebAPI.Models.RequestModel.Order.OrderDetail;

namespace POS_WebAPI.Models.RequestModel.Order
{
    public class OrderDeleteReq
    {
        public string? Id { get; set; }
        public ICollection<OrderDetailDeleteReq>? OrderDetails { get; set; }
    }
}
