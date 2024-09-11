using System.Net.Http.Headers;
using System.Net.Http.Json;
using Microsoft.Extensions.Logging;

namespace SkolmatenApi.Client;

public partial class SkolmatenClient: IDisposable
{
    private const string ApiVersion = "3";
    public SkolmatenClient(ILogger<SkolmatenClient> logger, string clientId, string clientVersionId, string language = "sv", 
        string baseUrl = "https://skolmaten.se/api/")
    {
        _logger = logger;
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri(baseUrl + ApiVersion + "/");
        
        _httpClient.DefaultRequestHeaders.Add("Client", clientId);
        _httpClient.DefaultRequestHeaders.Add("ClientVersion", clientVersionId);
        
        _httpClient.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue(language, 1.0));
    }

    private readonly HttpClient _httpClient;
    private readonly ILogger<SkolmatenClient> _logger;

    private async Task<TData> GetAsync<TData>(string endpoint)
    {
        _logger.Log(LogLevel.Information, $"GET {endpoint}");
        HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
        TData? deserialized = await response.Content.ReadFromJsonAsync<TData>();

        if (deserialized == null)
        {
            throw new Exception("Failed to deserialize server response!");
        }

        return deserialized;
    }
    
    public void Dispose()
    {
        _httpClient.Dispose();
    }
}