using POS_UI.Models.Product;
using POS_UI.Models.Response;

namespace POS_UI.Service;

public class ProductService : BaseService
{
    public async Task<List<ProductResponse>> GetAllAsync()
    {
        var url = "http://sonitab-001-site1.atempurl.com/api/product";
        var data = await GetAsync<Response<ProductResponse>>(url);
        return data?.Result ?? new List<ProductResponse>();
    }

    public async Task<string> Create(ProductResponse response)
    {
        return null!;
    }
}