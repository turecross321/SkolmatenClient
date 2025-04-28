using SkolmatenApi.Types.Responses;

namespace SkolmatenApi.Types;

public record MenuBulletin
{
    public required Guid Id { get; init; }
    public required long? OldId { get; init; }
    public required DateTimeOffset Activate { get; init; }
    public required DateTimeOffset Deactivate { get; init; }
    public required string? Link { get; init; }
    public required string Text { get; init; }
    public required string? ImageUrl { get; init; }
    public required Image? Image { get; init; }
    public required DateTimeOffset CreatedAt { get; init; }
    public required DateTimeOffset UpdatedAt { get; init; }

    public static MenuBulletin FromResponse(MenuBulletinResponse response)
    {
        return new MenuBulletin
        {
            Id = response.Id,
            OldId = response.OldId,
            Activate = response.Activate,
            Deactivate = response.Deactivate,
            Link = response.Link,
            Text = response.Text,
            ImageUrl = response.ImageUrl,
            Image = response.Image != null ? Types.Image.FromResponse(response.Image) : null,
            CreatedAt = response.CreatedAt,
            UpdatedAt = response.UpdatedAt
        };

    }
}