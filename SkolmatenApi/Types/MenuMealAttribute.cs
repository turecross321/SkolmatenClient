using SkolmatenApi.Types.Responses;

namespace SkolmatenApi.Types;

public record MenuMealAttribute
{
    public required Guid Id { get; init; }
    public required long? OldId { get; init; }
    public required string Name { get; init; }
    public required string EnglishName { get; init; }
    public required string SwedishName { get; init; }
    public required DateTimeOffset CreatedAt { get; init; }
    public required DateTimeOffset UpdatedAt { get; init; }

    public static MenuMealAttribute FromResponse(MenuMealAttributeResponse response)
    {
        return new MenuMealAttribute
        {
            Id = response.Id,
            OldId = response.OldId,
            Name = response.Name,
            EnglishName = response.EnglishName,
            SwedishName = response.SwedishName,
            CreatedAt = response.CreatedAt,
            UpdatedAt = response.UpdatedAt
        };
    }
}