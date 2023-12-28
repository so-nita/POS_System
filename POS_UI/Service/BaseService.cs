using Newtonsoft.Json;
using POS_UI.Models;
using POS_UI.Models.Responses;
using System.Text;

namespace POS_UI.Service;

public abstract class BaseService
{
    protected readonly HttpClient _httpClient;

    protected BaseService()
    {
        _httpClient = HttpClientManager.GetClient();
    }

    protected async Task<T> GetAsync<T>(string urlEndpoint)
    {
        try
        {
            var response = await _httpClient.GetAsync(urlEndpoint);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonString)!;
            }

            return default!;
        }
        catch (Exception ex)
        {
            return default!;
        }
    }

    protected async Task<TResponse> PostAsync<TRequest,TResponse>(string urlEndpoint, TRequest model)
    {
        try
        {
            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(urlEndpoint, content);
            if(response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TResponse>(jsonString)!;
            }
            return default!;
        }catch (Exception ex)
        {
            return default!;
        }
    }

    protected async Task<TResponse> PutAsync<TRequest, TResponse>(string urlEndpoint, TRequest model)
    {
        try
        {
            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json,Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(urlEndpoint, content);
            if(response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();    
                return JsonConvert.DeserializeObject<TResponse> (jsonString)!;
            }
            return default!;
        }catch(Exception ex)
        {
            return default!;
        }
    }

    protected async Task<Response<string>> DeleteAsync<T>(string urlEndpoint)
    {
        try
        {
            var response = await _httpClient.DeleteAsync(urlEndpoint);
            if(response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Response<string>>(jsonString)!;
            }
            return default!;
        }catch (Exception ex)
        {
            return default!;
        }
    }

    protected async Task<T> GetByIdAsync<T>(string urlEndpoint, Key key)
    {
        try
        {
            string url = $"{urlEndpoint}/{key}";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonString)!;
            }

            return default!;
        }
        catch (Exception ex)
        {
            return default!;
        }
    }


}
