using SkolmatenApi.Types;
using SkolmatenApi.Types.Responses;

namespace SkolmatenApi.Client;

public partial class SkolmatenClient
{
    public async Task<IEnumerable<District>> GetDistrictsAsync(Province province)
    {
        DistrictsResponse response = await _GetDistrictsAsync(province.Id);
        return response.Districts.Select(d => new District()
        {
            Id = d.Id,
            Name = d.Name,
            Province = province
        });
    }
    
    private Task<DistrictsResponse> _GetDistrictsAsync(long provinceId)
    {
        return GetAsync<DistrictsResponse>($"districts?province={provinceId}");
    }
}