using SkolmatenApi.Attributes;

namespace SkolmatenApi.Types.UrlParameters;

public class GetMenuParameters: UrlParameters
{
    // Route Parameter
    public Guid? SchoolId { get; init; }
    
    public string? SchoolUrlName { get; init; }
    
    [UrlParameter("week")]
    public required int Week { get; init; }
    
    [UrlParameter("year")]
    public required int Year { get; init; }
}