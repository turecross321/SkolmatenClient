using SkolmatenApi.Types;
using SkolmatenApi.Types.Responses;
using SkolmatenApi.Types.UrlParameters;

namespace SkolmatenApi.Client;

public partial class SkolmatenClient
{
    /// <summary>
    /// Fetch the menu during a specific week for a school using its url name
    /// </summary>
    /// <param name="schoolUrlName">The url name for the school - eg. "rokskola" </param>
    /// <param name="week">The week</param>
    /// <param name="year">The year</param>
    public async Task<Menu> GetMenuAsync(string schoolUrlName, int week, int year)
    {
        MenuResponse response = await GetMenuAsync_(new GetMenuParameters
        {
            SchoolUrlName = schoolUrlName,
            Week = week,
            Year = year,

        });

        return Menu.FromResponse(response);
    }
    
    /// <summary>
    /// Fetch the menu during a specific week for a school using its ID
    /// </summary>
    /// <param name="schoolId">The GUID ID for the school - eg. "52a571c0-14cc-4daf-835a-c1cf08119f31" </param>
    /// <param name="week">The week</param>
    /// <param name="year">The year</param>
    /// <returns></returns>
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
    
    /// <summary>
    /// Fetch the menu during a specific week for a school
    /// </summary>
    /// <param name="school">The school</param>
    /// <param name="week">The week</param>
    /// <param name="year">The year</param>
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
        if (parameters.SchoolUrlName != null)
        {
            return GetAsync<MenuResponse>($"menu/school/{parameters.SchoolUrlName}", parameters);
        }
        
        return GetAsync<MenuResponse>($"menu/{parameters.SchoolId}", parameters);
    }
}