using SkolmatenApi.Attributes;

namespace SkolmatenApi.Types.UrlParameters;

public class GetMenuParameters: UrlParameters
{
    [UrlParameter("school")]
    public required long SchoolId { get; init; }
    
    /// <summary>
    /// Limit of how many weeks to fetch
    /// </summary>
    [UrlParameter("limit")]
    public required int WeekLimit { get; init; }
    
    [UrlParameter("offset")]
    public required int? WeekOffset { get; init; }
    
    /// <summary>
    /// Week that the menu listing should start from
    /// </summary>
    [UrlParameter("week")]
    public required int? SpecificWeek { get; init; }
    
    [UrlParameter("year")]
    public required int? Year { get; init; }
}