using SkolmatenApi.Types.Responses;

namespace SkolmatenApi.Types;

public record MenuMeal
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required DateTimeOffset CreatedAt { get; init; }
    public required DateTimeOffset UpdatedAt { get; init; }
    public required Guid DayId { get; init; }
    public required IEnumerable<MenuMealAttribute> MealAttributes { get; init; }

    public static MenuMeal FromResponse(MenuMealResponse response)
    {
        return new MenuMeal
        {
            Id = response.Id,
            Name = response.Name,
            CreatedAt = response.CreatedAt,
            UpdatedAt = response.UpdatedAt,
            DayId = response.DayId,
            MealAttributes = response.MealAttributes.Select(MenuMealAttribute.FromResponse),
        };
    }
}