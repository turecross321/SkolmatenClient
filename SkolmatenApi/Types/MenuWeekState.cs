using SkolmatenApi.Types.Responses;

namespace SkolmatenApi.Types;

public class MenuWeekState
{
    public required Guid Id { get; init; }
    public required long? OldId { get; init; }
    public required DateTimeOffset CreatedAt { get; init; }
    public required DateTimeOffset UpdatedAt { get; init; }
    public required Guid MenuId { get; init; }
    public required int State { get; init; }
    public required int Week { get; init; }
    public required int Year { get; init; }
    public required IEnumerable<MenuDay> Days { get; init; }
    
    public static MenuWeekState FromResponse(MenuWeekStateResponse response)
    {
        return new MenuWeekState
        {
            Id = response.Id,
            OldId = response.OldId,
            CreatedAt = response.CreatedAt,
            UpdatedAt = response.UpdatedAt,
            MenuId = response.MenuId,
            State = response.State,
            Week = response.Week,
            Year = response.Year,
            Days = response.Days.Select(MenuDay.FromResponse)
        };
    }
}