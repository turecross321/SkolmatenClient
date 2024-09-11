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
        return response.Schools.Select(s => new School
        {
            Id = s.Id,
            Name = s.Name,
            District = district,
            UserDistance = null,
            UrlName = null
        });
    }

    public async Task<IEnumerable<School>> GetSchoolsNearbyAsync(double latitude, double longitude)
    {
        SchoolsNearbyResponse response = await _GetSchoolsNearbyAsync(new GetSchoolsNearbyParameters()
        {
            Latitude = latitude,
            Longitude = longitude
        });
        return response.Schools.Select(s => new School
        {
            Id = s.Id,
            Name = s.Name,
            UserDistance = s.UserDistance,
            District = null,
            UrlName = null
        });
    }
    
    private Task<SchoolsNearbyResponse> _GetSchoolsNearbyAsync(GetSchoolsNearbyParameters parameters)
    {
        return GetAsync<SchoolsNearbyResponse>($"schools/nearby", parameters);
    } 
    
    private Task<SchoolsResponse> _GetSchoolsAsync(GetSchoolsParameters parameters)
    {
        return GetAsync<SchoolsResponse>($"schools", parameters);
    }
}