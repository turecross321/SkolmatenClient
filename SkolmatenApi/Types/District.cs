namespace SkolmatenApi.Types;

public record District
{
    public required string Name { get; init; }
    public required long Id { get; init; }
    public required Province Province { get; init; }
    public required string? UrlName { get; init; }
}