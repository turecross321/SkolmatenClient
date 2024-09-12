using Microsoft.Extensions.Logging;
using SkolmatenApi.Client;
using SkolmatenApi.Types;

namespace Skolmaten.Examples;

public class Examples(SkolmatenClient client, ILogger logger)
{
    
    public async Task PrintFirstMeal()
    {
        IEnumerable<Province> provinces = await client.GetProvincesAsync();
        IEnumerable<District> districts = await client.GetDistrictsAsync(provinces.Last());
        IEnumerable<School> schools = await client.GetSchoolsAsync(districts.Last());
        School school = schools.Last();

        Menu menu = await client.GetRecentMenu(school);
        DayMenu dayMenu = menu.Weeks.First().Days.First();

        foreach (string meal in dayMenu.Meals)
        {
            Console.WriteLine(meal);
        }
    }
    
    public async Task PrintEverySchool()
    {
        var provinces = await client.GetProvincesAsync();
        List<School> allSchools = new List<School>();

        logger.LogInformation("Fetching every single school!");

        foreach (Province province in provinces)
        {
            var districts = await client.GetDistrictsAsync(province);
            foreach (District district in districts)
            {
                var schools = await client.GetSchoolsAsync(district);
                allSchools.AddRange(schools);
            }
        }

        foreach (School school in allSchools)
        {
            Console.WriteLine($"[{school.District?.Name}] {school.Name}");
        }
    }
}