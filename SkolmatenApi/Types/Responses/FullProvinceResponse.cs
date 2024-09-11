namespace SkolmatenApi.Types.Responses;

public record FullProvinceResponse : MinimalProvinceResponse
{
    public required string UrlName { get; init; }
}