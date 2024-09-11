namespace SkolmatenApi.Types.Responses;

public record SchoolsResponse: IResponse
{
    public required MinimalSchoolResponse[] Schools { get; init; }
    public required MinimalDistrictResponse District { get; init; }
}