using SkolmatenApi.Attributes;

namespace SkolmatenApi.Types.UrlParameters;

public class GetSchoolsNearbyParameters: UrlParameters
{
    [UrlParameter("longitude")]
    public double Longitude { get; init; }
    
    [UrlParameter("latitude")]
    public double Latitude { get; init; }
}