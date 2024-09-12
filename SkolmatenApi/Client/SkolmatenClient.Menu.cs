using SkolmatenApi.Types;
using SkolmatenApi.Types.Responses;
using SkolmatenApi.Types.UrlParameters;

namespace SkolmatenApi.Client;

public partial class SkolmatenClient
{
    public Task<Menu> GetMenu(School school, int weekLimit, int specificWeek, int year)
    {
        return GetMenu(school.Id, weekLimit, null, specificWeek, year);
    }
    
    public Task<Menu> GetMenu(long id, int weekLimit, int specificWeek, int year)
    {
        return GetMenu(id, weekLimit, null, specificWeek, year);
    }
    
    public Task<Menu> GetRecentMenu(School school, int weekLimit = 1, int weekOffset = 0)
    {
        return GetMenu(school.Id, weekLimit, weekOffset, null, null);
    }
    
    public Task<Menu> GetRecentMenu(long schoolId, int weekLimit = 1, int weekOffset = 0)
    {
        return GetMenu(schoolId, weekLimit, weekOffset, null, null);
    }
    
    private async Task<Menu> GetMenu(long schoolId, int weekLimit, int? weekOffset, int? specificWeek, int? year)
    {
        MenuResponse response = await GetMenu(new GetMenuParameters
        {
            SchoolId = schoolId,
            WeekLimit = weekLimit,
            WeekOffset = weekOffset,
            SpecificWeek = specificWeek,
            Year = year,

        });
        return new Menu
        {
            Weeks = response.Weeks.Select(w => new WeekMenu
            {
                Year = w.Year,
                WeekNumber = w.Number,
                Days = w.Days.Select(d => new DayMenu
                {
                    Date = DateTimeOffset.FromUnixTimeSeconds(d.Date),
                    Meals = d.Items
                })
                }),
            School = new School
            {
                Id = response.School.Id,
                Name = response.School.Name,
                District = new District
                {
                    Id = response.School.District.Id,
                    Name = response.School.District.Name,
                    Province = new Province
                    {
                        Id = response.School.District.Province.Id,
                        Name = response.School.District.Province.Name,
                        UrlName = response.School.District.Province.UrlName
                    },
                    UrlName = response.School.District.UrlName
                },
                UserDistance = null,
                UrlName = response.School.UrlName
            },
            BulletIns = response.BulletIns
        };

    }
    
    private Task<MenuResponse> GetMenu(GetMenuParameters parameters)
    {
        return GetAsync<MenuResponse>("menu", parameters);
    }
}