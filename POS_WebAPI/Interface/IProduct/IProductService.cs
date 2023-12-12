using POS_WebAPI.Models;
using POS_WebAPI.Models.RequestModel.Product;
using POS_WebAPI.Models.Response;

namespace POS_WebAPI.Interface.Product;

public interface IProductService : IService<ProductResponse,ProductCreateReq, ProductUpdateReq>
{ 

}