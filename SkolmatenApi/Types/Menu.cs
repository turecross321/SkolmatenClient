using SkolmatenApi.Types.Responses;

namespace SkolmatenApi.Types;

public record Menu
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    
    public required MenuWeekState? WeekState { get; init; }
    public required MenuBulletin? Bulletin { get; init; }
    public required School School { get; init; }

    public static Menu FromResponse(MenuResponse response)
    {
        return new Menu
        {
            Id = response.Id,
            Name = response.Name,
            WeekState = response.WeekState != null ? MenuWeekState.FromResponse(response.WeekState) : null,
            Bulletin = response.Bulletin != null ? MenuBulletin.FromResponse(response.Bulletin) : null,
            School = School.FromResponse(response.School)
        };
    }
}