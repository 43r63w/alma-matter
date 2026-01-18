using Almamatter.Application.Models.Responses;
using Almamatter.Application.Models.Review;

namespace Almamatter.Application.Interfaces;
public interface IReviewService
{
    Task<CreateReviewResponse> CreateReviewAsync(
        CreateReviewModel model,
        CancellationToken cancellationToken = default);
}