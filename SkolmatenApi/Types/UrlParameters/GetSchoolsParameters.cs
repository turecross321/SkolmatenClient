using SkolmatenApi.Attributes;

namespace SkolmatenApi.Types.UrlParameters;

public class GetSchoolsParameters: UrlParameters
{
    [UrlParameter("district")]
    public required long DistrictId { get; init; }
}