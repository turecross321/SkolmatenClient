using System.Text.Json.Serialization;

namespace SkolmatenApi.Types.Responses;

public record MenuWeekStateResponse
{
    public required Guid Id { get; init; }
    public required long? OldId { get; init; }
    public required DateTimeOffset CreatedAt { get; init; }
    public required DateTimeOffset UpdatedAt { get; init; }
    public required Guid MenuId { get; init; }
    public required int State { get; init; }
    public required int Week { get; init; }
    public required int Year { get; init; }
    [JsonPropertyName("Days")]
    public required MenuDayResponse[] Days { get; init; }
}