using Almamatter.Api.Contracts.Pagination;

namespace Almamatter.Api.Contracts;

public record GetReviewRequest(
     Guid? UniversityId) : PaginationRequest;
