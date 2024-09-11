namespace SkolmatenApi.Types.Responses;

public record DistrictsResponse: IResponse
{
    public required MinimalDistrictResponse[] Districts { get; init; }
    public required MinimalProvinceResponse Province { get; init; }
}