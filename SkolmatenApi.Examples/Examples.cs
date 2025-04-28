using Microsoft.Extensions.Logging;
using SkolmatenApi.Client;
using SkolmatenApi.Types;

namespace Skolmaten.Examples;

public class Examples(SkolmatenClient client, ILogger logger)
{
    public async Task PrintSchoolMenu()
    {
        IEnumerable<Province> provinces = await client.GetProvincesAsync();
        var province = provinces.Last();
        Console.WriteLine(province.Name);
        
        IEnumerable<District> districts = await client.GetDistrictsAsync(province);
        var district = districts.Last();
        Console.WriteLine(district.Name);
        
        IEnumerable<School> schools = await client.GetSchoolsAsync(district);
        School school = schools.Last();
        Console.WriteLine(school.Name);

        Menu menu = await client.GetMenuAsync(school, 20, 2024);

        foreach (MenuDay day in menu.WeekState.Days)
        {
            foreach (MenuMeal meal in day.Meals)
            {
                Console.WriteLine($"{day.Date}: {meal.Name}");
            }
        }
    }
    
    public async Task PrintEveryDistrict()
    {
        var allDistricts = await GetEveryDistrict();

        foreach (District district in allDistricts)
        {
            Console.WriteLine($"[{district.Name}] {district.Id}");
        }
    }
    
    public async Task PrintEverySchool()
    {
        var districts = await GetEveryDistrict();
        
        foreach (District district in districts)
        {
            var schools = await client.GetSchoolsAsync(district);
            foreach (School school in schools)
            {
                Console.WriteLine($"[{district.Name}] {school.Name}");
            }
        }
    }
    
    private async Task<List<District>> GetEveryDistrict()
    {
        var provinces = await client.GetProvincesAsync();
        List<District> allDistricts = new List<District>();

        logger.LogInformation("Fetching every single district!");

        foreach (Province province in provinces)
        {
            var districts = await client.GetDistrictsAsync(province);
            allDistricts.AddRange(districts);
        }

        return allDistricts;
    }
}