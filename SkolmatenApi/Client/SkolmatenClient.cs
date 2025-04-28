using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using SkolmatenApi.Types.Responses;
using SkolmatenApi.Types.UrlParameters;

namespace SkolmatenApi.Client;

/// <summary>
/// Client for Skolmatens' v4 API
/// </summary>
public partial class SkolmatenClient: IDisposable
{
    private const string ApiVersion = "4";
    
    /// <summary>
    /// Constructor for Skolmaten client
    /// </summary>
    /// <param name="logger">Logger to use</param>
    /// <param name="clientToken">Client token used to authenticate. The default value is taken from the web app.</param>
    /// <param name="language">Accept language header. This probably doesn't actually change anything.</param>
    /// <param name="baseUrl">Base url for skolmaten's API</param>
    public SkolmatenClient(ILogger logger, string clientToken = "web-eaa12e50-c84c-4b4a-9cfe-4e3fcbcd9165", string language = "sv", 
        string baseUrl = "https://skolmaten.se/api/")
    {
        _logger = logger;
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri(baseUrl + ApiVersion + "/");
        
        _httpClient.DefaultRequestHeaders.Add("Client-Token", clientToken);
        
        _httpClient.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue(language, 1.0));
    }

    private readonly HttpClient _httpClient;
    private readonly ILogger _logger;
    
    private async Task<TData> GetAsync<TData>(string endpoint, UrlParameters? urlParameters) where TData : IResponse
    {
        if (urlParameters != null)
            endpoint += urlParameters.ToUrl();
        
        _logger.Log(LogLevel.Information, $"GET {endpoint}");
        HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
        try
        {
            TData? deserialized = await response.Content.ReadFromJsonAsync<TData>();
            return deserialized!;
        }
        catch (JsonException e)
        {
            string rawResponse = await response.Content.ReadAsStringAsync();
            _logger.LogError("Failed to deserialize server response!" + rawResponse);
            throw;
        }
    }

    /// <inheritdoc />
    public void Dispose()
    {
        _httpClient.Dispose();
    }
}