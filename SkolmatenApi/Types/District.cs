namespace SkolmatenApi.Types;

public record District
{
    public required string Name { get; init; }
    public required long Id { get; init; }
    public Province Province { get; init; }
}