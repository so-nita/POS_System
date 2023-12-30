using POS_WebAPI.Interface;
using POS_WebAPI.Models.RequestModel.Receipt;

namespace POS_WebAPI.Services
{
    public interface IReceitpService : IService<ReceiptResponse,ReceiptCreateReq,ReceiptUpdateReq>
    {
    }
}
