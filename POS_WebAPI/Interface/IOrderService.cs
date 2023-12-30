using POS_WebAPI.Models.RequestModel.Order;
using POS_WebAPI.Models.Response;
using System.Configuration;

namespace POS_WebAPI.Interface;

public interface IOrderService : IService<OrderResponse, OrderCreateReq, OrderUpdateReq>
{
    public Response<string> Delete(OrderDeleteReq request);
}
