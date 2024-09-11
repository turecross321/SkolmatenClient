namespace SkolmatenApi.Types.Responses;

public record DistrictResponse
{
    public required long Id { get; init; }
    public required string Name { get; init; }
}