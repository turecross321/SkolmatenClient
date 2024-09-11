namespace SkolmatenApi.Types.Responses;

public record SchoolsResponse: IResponse
{
    public required SchoolResponse[] Schools { get; init; }
    public required DistrictResponse District { get; init; }
}