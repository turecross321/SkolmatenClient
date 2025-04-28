namespace SkolmatenApi.Types.Responses;

public record DistrictResponse
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public string? UrlName { get; init; }
    public ImageResponse? Image { get; init; }
    
    public long? OldId { get; init; }
    public Guid? CustomerId { get; init; }
    public bool? FeedbackAllowed { get; init; }
    public string? ImageUrl { get; init; }
    public Guid? ProvinceId { get; init; }
    public DateTimeOffset? CreatedAt { get; init; }
    public DateTimeOffset? UpdatedAt { get; init; }
    public Guid? MenuId { get; init; }
    public Guid? BulletinId { get; init; }
}