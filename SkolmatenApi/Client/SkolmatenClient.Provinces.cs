using SkolmatenApi.Types;
using SkolmatenApi.Types.Responses;

namespace SkolmatenApi.Client;

public partial class SkolmatenClient
{
    /// <summary>
    /// Get all provinces (län) in Sweden that use Skolmaten's services
    /// </summary>
    public async Task<IEnumerable<Province>> GetProvincesAsync()
    {
        ProvincesResponse response = await _GetProvincesAsync();
        return response.Provinces.Select(Province.FromResponse);
    }

    /// <summary>
    /// Get province (län) with specific ID
    /// </summary>
    public async Task<Province> GetProvinceByIdAsync(Guid id)
    {
        ProvinceResponse response = await _GetProvinceByIdAsync(id);
        return Province.FromResponse(response);
    }
    
    private Task<ProvincesResponse> _GetProvincesAsync()
    {
        return GetAsync<ProvincesResponse>("provinces", null);
    }
    
    private Task<ProvinceResponse> _GetProvinceByIdAsync(Guid guid)
    {
        return GetAsync<ProvinceResponse>($"provinces/{guid.ToString()}", null);
    }
}