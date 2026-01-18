namespace Almamatter.Application.Models.Responses;

public sealed record CreateReviewResponse(
    string Author,
    string Message,
    bool IsSuccess);