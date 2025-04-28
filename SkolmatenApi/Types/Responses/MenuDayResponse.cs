using System.Text.Json.Serialization;

namespace SkolmatenApi.Types.Responses;

public record MenuDayResponse
{
    public required Guid Id { get; init; }
    public required long? OldId { get; init; }
    public required DateTimeOffset CreatedAt { get; init; }
    public required DateTimeOffset UpdatedAt { get; init; }
    public required Guid MenuId { get; init; }
    public required string? Cancelled { get; init; }
    public required DateTimeOffset Date { get; init; }
    public required Guid WeekStateId { get; init; }
    [JsonPropertyName("Meals")]
    public MenuMealResponse[] Meals { get; init; }
}