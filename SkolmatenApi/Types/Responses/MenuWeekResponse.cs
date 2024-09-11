namespace SkolmatenApi.Types.Responses;

public record MenuWeekResponse
{
    public required int Year { get; init; }
    public required int Number { get; init; }
    public required MenuDayResponse[] Days { get; init; }
}