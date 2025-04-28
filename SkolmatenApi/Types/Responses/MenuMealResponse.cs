using System.Text.Json.Serialization;

namespace SkolmatenApi.Types.Responses;

public record MenuMealResponse
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required DateTimeOffset CreatedAt { get; init; }
    public required DateTimeOffset UpdatedAt { get; init; }
    public required Guid DayId { get; init; }
    public Guid[] MealAttributeIds { get; init; }
    [JsonPropertyName("MealAttributes")]
    public MenuMealAttributeResponse[] MealAttributes { get; init; }
    
}