namespace SkolmatenApi.Types;

/// <summary>
/// Meal menu for a week
/// </summary>
public record WeekMenu
{
    public required int Year { get; init; }
    public required int WeekNumber { get; init; }
    public required IEnumerable<DayMenu> Days { get; init; }
}