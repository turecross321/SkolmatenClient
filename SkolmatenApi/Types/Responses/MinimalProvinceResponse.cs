namespace SkolmatenApi.Types.Responses;

public record MinimalProvinceResponse
{
    public required long Id { get; init; }
    public required string Name { get; init; }
}