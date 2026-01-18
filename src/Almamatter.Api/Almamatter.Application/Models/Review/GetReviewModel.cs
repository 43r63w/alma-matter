namespace Almamatter.Application.Models.Review;

public sealed record GetReviewModel(
    Guid? UniversityId, 
    int Limit);