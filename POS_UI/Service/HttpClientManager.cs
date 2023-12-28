using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_UI.Service;

public static class HttpClientManager
{
    private static readonly HttpClient _httpClient = new HttpClient();

    public static HttpClient GetClient()
    {
        return _httpClient;
    }
}
