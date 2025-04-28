using SkolmatenApi.Types.Responses;

namespace SkolmatenApi.Types;

public record Province
{
    public required Guid Id { get; init; }
    public required long? OldId { get; init; }
    public required string Name { get; init; }
    public required string? UrlName { get; init; }
    public required DateTimeOffset? CreatedAt { get; init; }
    public required DateTimeOffset? UpdatedAt { get; init; }
    public required IEnumerable<District>? Districts { get; init; }

    public static Province FromResponse(ProvinceResponse response)
    {
        return new Province
        {
            Id = response.Id,
            OldId = response.OldId,
            Name = response.Name,
            UrlName = response.UrlName,
            CreatedAt = response.CreatedAt,
            UpdatedAt = response.UpdatedAt,
            Districts = response.Districts?.Select(District.FromResponse)
        };
    }
}