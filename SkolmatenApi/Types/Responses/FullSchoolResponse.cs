namespace SkolmatenApi.Types.Responses;

public record FullSchoolResponse: MinimalSchoolResponse
{
    public required string UrlName { get; init; }
    public required string ImageUrl { get; init; }
    public required FullDistrictResponse District { get; init; }
} 