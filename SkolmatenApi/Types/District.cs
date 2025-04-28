using SkolmatenApi.Types.Responses;

namespace SkolmatenApi.Types;

public record District
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required long? OldId { get; init; }
    public required Guid? CustomerId { get; init; }
    public required string? UrlName { get; init; }
    public required bool? FeedbackAllowed { get; init; }
    public required string? ImageUrl { get; init; }
    public required Image? Image { get; init; }
    public required Guid? ProvinceId { get; init; }
    public required DateTimeOffset? CreatedAt { get; init; }
    public required DateTimeOffset? UpdatedAt { get; init; }
    public required Guid? MenuId { get; init; }
    public required Guid? BulletinId { get; init; }
    
    public static District FromResponse(DistrictResponse response)
    {
        return new District
        {
            Id = response.Id,
            Name = response.Name,
            OldId = response.OldId,
            CustomerId = response.CustomerId,
            UrlName = response.UrlName,
            FeedbackAllowed = response.FeedbackAllowed,
            ImageUrl = response.ImageUrl,
            Image = response.Image != null ? Types.Image.FromResponse(response.Image) : null,
            ProvinceId = response.ProvinceId,
            CreatedAt = response.CreatedAt,
            UpdatedAt = response.UpdatedAt,
            MenuId = response.MenuId,
            BulletinId = response.BulletinId
        };
    }
}