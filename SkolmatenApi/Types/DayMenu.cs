namespace SkolmatenApi.Types;

public struct DayMenu
{
    public required DateTimeOffset Date { get; init; }
    public required IEnumerable<string> Meals { get; init; }
}