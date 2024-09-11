# SkolmatenClient
dotnet library for communicating with Skolmaten's API

## Example
```cs
using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
Logger<SkolmatenClient> logger = new Logger<SkolmatenClient>(factory);

using SkolmatenClient client = new(logger, ClientId, ClientVersionId);

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
```

### Output
```
Potatisbullar alt blodpudding serveras med keso & lingon
```
