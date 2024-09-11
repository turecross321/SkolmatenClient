namespace SkolmatenApi.Types;

public record Province
{
    public required string Name { get; init; }
    public required long Id { get; init; }
    public required string? UrlName { get; init; }
}