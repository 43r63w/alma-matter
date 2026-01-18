using Almamatter.Application.Models.Responses;

namespace Almamatter.Api.Controllers;

public class ReviewController(
    IReviewService reviewService,
    ILogger<ReviewController> logger) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<CreateReviewResponse>> PostReview(
        [FromBody] CreateReviewRequest request,
        CancellationToken cancellationToken = default)
    {
        logger.LogInformation("Creating review");

        var toModel = request.ToCreateReviewModel();
        var response = await reviewService.CreateReviewAsync(toModel, cancellationToken);

        if (!response.IsSuccess)
            return BadRequest();

        logger.LogInformation("Review created successfully");
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<PaginationResponse<GetReviewResponse>>> GetReviewAsync()
    {
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<PaginationResponse<GetReviewResponse>>> GetReviewsAsync()
    {
        return Ok();
    }
}