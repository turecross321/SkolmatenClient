using SkolmatenApi.Types;
using SkolmatenApi.Types.Responses;
using SkolmatenApi.Types.UrlParameters;

namespace SkolmatenApi.Client;

public partial class SkolmatenClient
{
    /// <summary>
    /// Get all districts (kommuner) in a specific province (län)
    /// </summary>
    /// <param name="province"></param>
    /// <returns></returns>
    public async Task<IEnumerable<District>> GetDistrictsAsync(Province province)
    {
        DistrictsResponse response = await _GetDistrictsAsync(new GetDistrictsParameters {ProvinceId = province.Id});
        return response.Districts.Select(District.FromResponse);
    }   
    
    private Task<DistrictsResponse> _GetDistrictsAsync(GetDistrictsParameters queries)
    {
        return GetAsync<DistrictsResponse>("districts", queries);
    }
}