using POS_WebAPI.Models.RequestModel.Order;

namespace POS_WebAPI.Interface;

public interface IOrderService : IService<OrderResponse, OrderCreateReq, OrderUpdateReq>
{

}
