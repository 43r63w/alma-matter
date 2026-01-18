using Almamatter.Application.Models.Review;

namespace Almamatter.Api.Exstensions.Mappings;

public static class ReviewMapper
{
    public static CreateReviewModel ToCreateReviewModel(this CreateReviewRequest review)
    {
        return new CreateReviewModel(
            review.Author,
            review.Content,
            review.Assessment,
            review.RatingInfrastructure,
            review.RatingTeaching,
            review.RatingAtmosphere,
            review.UniversityId);
    }

    public static GetReviewModel ToGetReviewModel(
        this GetReviewRequest review)
    {
        return new GetReviewModel(review.UniversityId, review.Limit);
    }
}