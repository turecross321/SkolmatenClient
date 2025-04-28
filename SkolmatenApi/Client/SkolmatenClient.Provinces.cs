using SkolmatenApi.Types;
using SkolmatenApi.Types.Responses;

namespace SkolmatenApi.Client;

public partial class SkolmatenClient
{
    public async Task<IEnumerable<Province>> GetProvincesAsync()
    {
        ProvincesResponse response = await _GetProvincesAsync();
        return response.Provinces.Select(Province.FromResponse);
    }

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