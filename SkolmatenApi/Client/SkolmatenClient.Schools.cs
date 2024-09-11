using SkolmatenApi.Types;
using SkolmatenApi.Types.Responses;

namespace SkolmatenApi.Client;

public partial class SkolmatenClient
{
    public async Task<IEnumerable<School>> GetSchoolsAsync(District district)
    {
        SchoolsResponse response = await _GetSchoolsAsync(district.Id);
        return response.Schools.Select(s => new School()
        {
            Id = s.Id,
            Name = s.Name,
            District = district
        });
    }
    
    private Task<SchoolsResponse> _GetSchoolsAsync(long districtId)
    {
        return GetAsync<SchoolsResponse>($"schools?district={districtId}");
    }
}