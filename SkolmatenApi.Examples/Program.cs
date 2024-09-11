using Microsoft.Extensions.Logging;
using SkolmatenApi.Client;
using SkolmatenApi.Types;

using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
Logger<SkolmatenClient> logger = new Logger<SkolmatenClient>(factory);

using SkolmatenClient client = new(logger, "CLIENTID", "CLIENTVERSIONID");
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
    Console.WriteLine($"[{school.District.Name}] {school.Name}");
}