using SkolmatenApi.Types.Responses;

namespace SkolmatenApi.Types;

public struct Image
{
    // todo: finish this
    public required string Type { get; init; } // todo: enum
    public required int[] Data { get; init; } // todo: byte[]?

    public static Image FromResponse(ImageResponse response)
    {
        return new Image
        {
            Type = response.Type,
            Data = response.Data
        };
    }
}