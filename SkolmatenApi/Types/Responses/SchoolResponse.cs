namespace SkolmatenApi.Types.Responses;

public record SchoolResponse
{
    public required long Id { get; init; }
    public required string Name { get; init; }
}