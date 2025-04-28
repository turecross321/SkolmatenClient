namespace SkolmatenApi.Types.Responses;

public record SchoolResponse
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required Guid MenuId { get; init; }
    
    public string? UrlName { get; init; }
    public ImageResponse? Image { get; init; }
    public DistrictResponse? District { get; init; }
}