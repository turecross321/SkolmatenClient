using System.Text.Json.Serialization;

namespace SkolmatenApi.Types.Responses;

public record ProvinceResponse : IResponse
{
    public Guid Id { get; init; }
    public long? OldId { get; init; }
    public string Name { get; init; }
    public string? UrlName { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset UpdatedAt { get; init; }
    
    [JsonPropertyName("Districts")]
    public DistrictResponse[]? Districts { get; init; }
}