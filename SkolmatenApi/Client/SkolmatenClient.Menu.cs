using SkolmatenApi.Types;
using SkolmatenApi.Types.Responses;
using SkolmatenApi.Types.UrlParameters;

namespace SkolmatenApi.Client;

public partial class SkolmatenClient
{
    public async Task<Menu> GetMenuAsync(Guid schoolId, int week, int year)
    {
        MenuResponse response = await GetMenuAsync_(new GetMenuParameters
        {
            SchoolId = schoolId,
            Week = week,
            Year = year,

        });

        return Menu.FromResponse(response);
    }
    
    public async Task<Menu> GetMenuAsync(School school, int week, int year)
    {
        MenuResponse response = await GetMenuAsync_(new GetMenuParameters
        {
            SchoolId = school.Id,
            Week = week,
            Year = year,

        });

        return Menu.FromResponse(response);
    }
    
    private Task<MenuResponse> GetMenuAsync_(GetMenuParameters parameters)
    {
        return GetAsync<MenuResponse>($"menu/{parameters.SchoolId}", parameters);
    }
}