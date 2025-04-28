using SkolmatenApi.Types.Responses;

namespace SkolmatenApi.Types;

public struct MenuDay
{
    public required Guid Id { get; init; }
    public required long? OldId { get; init; }
    public required DateTimeOffset CreatedAt { get; init; }
    public required DateTimeOffset UpdatedAt { get; init; }
    public required Guid MenuId { get; init; }
    public required bool? Cancelled { get; init; }
    public required DateTimeOffset Date { get; init; }
    public required Guid WeekStateId { get; init; }
    public required IEnumerable<MenuMeal> Meals { get; init; }

    public static MenuDay FromResponse(MenuDayResponse response)
    {
        return new MenuDay
        {
            Id = response.Id,
            OldId = response.OldId,
            CreatedAt = response.CreatedAt,
            UpdatedAt = response.UpdatedAt,
            MenuId = response.MenuId,
            Cancelled = response.Cancelled,
            Date = response.Date,
            WeekStateId = response.WeekStateId,
            Meals = response.Meals.Select(MenuMeal.FromResponse)
        };

    }
}