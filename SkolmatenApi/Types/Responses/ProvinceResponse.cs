namespace SkolmatenApi.Types.Responses;

public record ProvinceResponse
{
    public required long Id { get; init; }
    public required string Name { get; init; }
}