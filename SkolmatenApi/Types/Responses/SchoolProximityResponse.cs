namespace SkolmatenApi.Types.Responses;

public record SchoolProximityResponse : MinimalSchoolResponse
{
    public required double UserDistance { get; init; }
}