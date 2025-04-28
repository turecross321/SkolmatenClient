using System.Text.Json.Serialization;

namespace SkolmatenApi.Types.Responses;

public record MenuMealAttributeResponse
{
    public required Guid Id { get; init; }
    public required long? OldId { get; init; }
    public required string Name { get; init; }
    [JsonPropertyName("en")]
    public required string EnglishName { get; init; }
    [JsonPropertyName("sv")]
    public required string SwedishName { get; init; }
    public required DateTimeOffset CreatedAt { get; init; }
    public required DateTimeOffset UpdatedAt { get; init; }
}
