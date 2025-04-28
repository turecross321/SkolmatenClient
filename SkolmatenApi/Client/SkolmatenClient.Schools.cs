using SkolmatenApi.Types;
using SkolmatenApi.Types.Responses;
using SkolmatenApi.Types.UrlParameters;

namespace SkolmatenApi.Client;

public partial class SkolmatenClient
{
    public async Task<IEnumerable<School>> GetSchoolsAsync(District district)
    {
        SchoolsResponse response = await _GetSchoolsAsync(new GetSchoolsParameters()
        {
            DistrictId = district.Id
        });
        return response.Schools.Select(School.FromResponse);
    }
    
    private Task<SchoolsResponse> _GetSchoolsAsync(GetSchoolsParameters parameters)
    {
        return GetAsync<SchoolsResponse>($"schools", parameters);
    }
}