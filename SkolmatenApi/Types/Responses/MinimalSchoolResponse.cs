namespace SkolmatenApi.Types.Responses;

public record MinimalSchoolResponse
{
    public required long Id { get; init; }
    public required string Name { get; init; }
}