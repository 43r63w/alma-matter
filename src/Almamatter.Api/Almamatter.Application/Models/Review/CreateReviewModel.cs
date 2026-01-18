namespace Almamatter.Application.Models.Review;

public sealed record CreateReviewModel(
    string Author,
    string Content,
    int Assessment,
    int RatingInfrastructure,
    int RatingTeaching,
    int RatingAtmosphere,
    Guid UniversityId);