namespace SkolmatenApi.Types;

public class School
{
    public required long Id { get; init; }
    public required string Name { get; init; }
    public required District? District { get; init; }
    
    public required double? UserDistance { get; init; }
    public required string UrlName { get; init; }
}