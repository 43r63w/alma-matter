using Almamatter.Application.Interfaces;
using Almamatter.Application.Models.Responses;
using Almamatter.Application.Models.Review;
using Almamatter.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Almamatter.Application.Services;

public sealed class ReviewService(ApplicationDbContext dbContext) : IReviewService
{
    public async Task<CreateReviewResponse> CreateReviewAsync(
        CreateReviewModel model,
        CancellationToken cancellationToken = default)
    {
        var entity = new Review
        {
            Id = Guid.NewGuid(),
            Author = model.Author,
            Content = model.Content,
            Assessment = model.Assessment,
            RatingInfrastructure = model.RatingInfrastructure,
            RatingAtmosphere = model.RatingAtmosphere,
            RatingTeaching = model.RatingTeaching,
            UniversityId = model.UniversityId,
        };
        dbContext.Reviews.Add(entity);
        await dbContext.SaveChangesAsync(cancellationToken);

        return new CreateReviewResponse(model.Author, model.Content, true);
    }

    public async Task<PaginationResponse<GetReviewResponse>> GetReviewsAsync(
        GetReviewModel model,
        CancellationToken cancellationToken = default)
    {
        var reviews = await dbContext.Reviews
            .AsNoTracking()
            .Where(e => e.UniversityId == model.UniversityId && model.UniversityId != null)
            .Select(e => new GetReviewResponse(
                e.Author,
                e.Content,
                e.Assessment,
                e.RatingInfrastructure,
                e.RatingAtmosphere,
                e.RatingTeaching,
                e.Like))
            .Take(model.Limit)
            .ToListAsync(cancellationToken);

        var reviewsCount = await dbContext.Reviews.CountAsync(cancellationToken);

        return new PaginationResponse<GetReviewResponse>(model.Limit, reviewsCount, reviews);
    }
}