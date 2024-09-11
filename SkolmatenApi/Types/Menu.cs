namespace SkolmatenApi.Types;

public record Menu
{
    public required IEnumerable<WeekMenu> Weeks { get; init; }
    public required School School { get; init; }
    public required string[] BulletIns { get; init; }
}