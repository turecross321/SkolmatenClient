namespace SkolmatenApi.Types.Responses;

public record ProvincesResponse : IResponse
{
    public required MinimalProvinceResponse[] Provinces { get; init; }
}