using SkolmatenApi.Types;
using SkolmatenApi.Types.Responses;
using SkolmatenApi.Types.UrlParameters;

namespace SkolmatenApi.Client;

public partial class SkolmatenClient
{
    /// <summary>
    /// Get all schools in specified district (kommun)
    /// </summary>
    /// <param name="district">District</param>
    public async Task<IEnumerable<School>> GetSchoolsAsync(District district)
    {
        SchoolsResponse response = await _GetSchoolsAsync(new GetSchoolsParameters()
        {
            DistrictId = district.Id
        });
        return response.Schools.Select(School.FromResponse);
    }
    
    // todo: implement search (api no version)
    // todo: implement schools nearby (api 3)
    
    private Task<SchoolsResponse> _GetSchoolsAsync(GetSchoolsParameters parameters)
    {
        return GetAsync<SchoolsResponse>($"schools", parameters);
    }
}