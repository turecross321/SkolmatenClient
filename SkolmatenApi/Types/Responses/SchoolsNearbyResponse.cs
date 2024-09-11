namespace SkolmatenApi.Types.Responses;

public record SchoolsNearbyResponse: IResponse
{
    public required SchoolProximityResponse[] Schools { get; init; }
}