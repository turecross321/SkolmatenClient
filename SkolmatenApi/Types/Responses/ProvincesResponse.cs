namespace SkolmatenApi.Types.Responses;

public record ProvincesResponse : IResponse
{
    public required ProvinceResponse[] Provinces { get; init; }
}