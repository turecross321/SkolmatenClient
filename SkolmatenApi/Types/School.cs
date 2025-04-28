using SkolmatenApi.Types.Responses;

namespace SkolmatenApi.Types;

public class School
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required Guid MenuId { get; init; }

    public static School FromResponse(SchoolResponse response)
    {
        return new School
        {
            Id = response.Id,
            Name = response.Name,
            MenuId = response.MenuId
        };
    }
}