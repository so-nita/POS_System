using POS_UI.Models;
using POS_UI.Models.Product;
using POS_UI.Models.Responses;

namespace POS_UI.Service;

public class ProductService : BaseService
{
    public async Task<Response<ProductResponse>> GetAllAsync()
    {
        var endpoint = "http://sonitab-001-site1.atempurl.com/api/product";
        var data = await GetAsync<Response<ProductResponse>>(endpoint);
        return data;
    }

    public async Task<Response<ProductResponse>> GetAsync(Key key)
    {
        var endpoint = "";
        var data = await GetByIdAsync<Response<ProductResponse>>(endpoint, key);
        return data;
    }

    public async Task<Response<ProductResponse>> CreateAsync(ProductCreateReq request)
    {
        var endpoint = "";
        var data = await PostAsync<ProductCreateReq, Response<ProductResponse>>(endpoint, request);
        return data;
    }

    public async Task<Response<ProductResponse>> UpdateAsync(ProductUpdateReq request)
    {
        var endpoint = "";
        var data = await PutAsync<ProductUpdateReq, Response<ProductResponse>>(endpoint, request);
        return data;
    }

    public async Task<Response<string?>> DeleteAsync(Key key)
    {
        var endpoint = $"/{key}";
        var data = await DeleteAsync<Response<string?>>(endpoint);
        return data!;
    }
}