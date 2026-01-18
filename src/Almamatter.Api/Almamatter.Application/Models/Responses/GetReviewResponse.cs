namespace Almamatter.Application.Models.Responses;

public sealed record GetReviewResponse(
    string Author,
    string Content,
    int Assessment,
    int RatingInfrastructure,
    int RatingTeaching,
    int RatingAtmosphere,
    int Like);

