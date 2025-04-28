using System.Text.Json.Serialization;

namespace SkolmatenApi.Types.Responses;

public record MenuResponse : IResponse
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required int NumberOfItems { get; init; }
    [JsonPropertyName("WeekState")]
    public MenuWeekStateResponse? WeekState { get; init; }
    [JsonPropertyName("Bulletin")]
    public MenuBulletinResponse? Bulletin { get; init; }
    [JsonPropertyName("School")]
    public SchoolResponse? School { get; init; }
}