namespace SkolmatenApi.Types.Responses;

public record MenuDayResponse
{
    public required long Date { get; init; }
    public string[] Items { get; init; }
}