namespace SkolmatenApi.Types.Responses;

public record FullDistrictResponse: MinimalDistrictResponse
{
    public required string UrlName { get; init; }
    public required FullProvinceResponse Province { get; init; }
}