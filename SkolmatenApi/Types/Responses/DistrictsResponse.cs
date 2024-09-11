namespace SkolmatenApi.Types.Responses;

public record DistrictsResponse: IResponse
{
    public required DistrictResponse[] Districts { get; init; }
    public required ProvinceResponse Province { get; init; }
}