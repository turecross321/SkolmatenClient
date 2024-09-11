namespace SkolmatenApi.Types.Responses;

public record MinimalDistrictResponse
{
    public required long Id { get; init; }
    public required string Name { get; init; }
}