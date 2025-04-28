namespace SkolmatenApi.Types.Responses;

public record MenuBulletinResponse
{
    public required Guid Id { get; init; }
    public required long? OldId { get; init; }
    public required DateTimeOffset Activate { get; init; }
    public required DateTimeOffset Deactivate { get; init; }
    public required string? Link { get; init; }
    public required string Text { get; init; }
    public required string? ImageUrl { get; init; }
    public required ImageResponse? Image { get; init; }
    public required DateTimeOffset CreatedAt { get; init; }
    public required DateTimeOffset UpdatedAt { get; init; }
}