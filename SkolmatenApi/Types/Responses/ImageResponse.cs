namespace SkolmatenApi.Types.Responses;

public record ImageResponse
{
    public string Type { get; init; }
    public int[] Data { get; init; }
}