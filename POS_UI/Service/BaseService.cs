using Newtonsoft.Json;

namespace POS_UI.Service;

public abstract class BaseService
{
    protected readonly HttpClient _httpClient;

    protected BaseService()
    {
        _httpClient = HttpClientManager.GetClient();
    }

    protected async Task<T> GetAsync<T>(string url)
    {
        try
        {
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
