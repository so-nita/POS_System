using Newtonsoft.Json;
using POS_UI.Model;
using POS_UI.Models;
using System.Text.Json;

namespace POS_UI.Service;

public class ProductService : BaseService
{
    private readonly HttpClient _client;
    public ProductService()
    {
        _client = new HttpClient();
    }
    public async Task<List<Product>> GetAllAsync()
    {
        try
        {
            var products = new List<Product>(); 
            var response = await _client.GetAsync(BaseUrl); 
            if(response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
                var data = JsonConvert.DeserializeObject<Response<Product>>(jsonString);
                products.AddRange(data.Result!);
            }
            return products;
        }catch(Exception ex) 
        {
            return null!; 
        }
    }
}
