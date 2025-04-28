using SkolmatenApi.Attributes;

namespace SkolmatenApi.Types.UrlParameters;

public class GetDistrictsParameters: UrlParameters
{
    [UrlParameter("province")]
    public required Guid? ProvinceId { get; init; }
}