namespace SkolmatenApi.Types.Responses;

public record MenuResponse: IResponse
{
    public required bool FeedbackAllowed { get; init; }
    public required MenuWeekResponse[] Weeks { get; init; }
    public required FullSchoolResponse School { get; init; }
    public required string[] BulletIns { get; init; }
}