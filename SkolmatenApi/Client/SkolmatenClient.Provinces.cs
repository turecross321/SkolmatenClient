using SkolmatenApi.Types;
using SkolmatenApi.Types.Responses;

namespace SkolmatenApi.Client;

public partial class SkolmatenClient
{
    public async Task<IEnumerable<Province>> GetProvincesAsync()
    {
        ProvincesResponse response = await _GetProvincesAsync();
        
        return response.Provinces.Select(p => new Province
        {
            Name = p.Name,
            Id = p.Id
        });
    }
    
    private Task<ProvincesResponse> _GetProvincesAsync()
    {
        return GetAsync<ProvincesResponse>("provinces");
    }
}