using SkolmatenApi.Types;
using SkolmatenApi.Types.Responses;
using SkolmatenApi.Types.UrlParameters;

namespace SkolmatenApi.Client;

public partial class SkolmatenClient
{
    public async Task<IEnumerable<District>> GetDistrictsAsync(Province province)
    {
        DistrictsResponse response = await _GetDistrictsAsync(new GetDistrictsParameters {ProvinceId = province.Id});
        return response.Districts.Select(d => new District
        {
            Id = d.Id,
            Name = d.Name,
            Province = province,
            UrlName = null
        });
    }
    
    private Task<DistrictsResponse> _GetDistrictsAsync(GetDistrictsParameters queries)
    {
        return GetAsync<DistrictsResponse>("districts", queries);
    }
}