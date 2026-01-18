namespace Almamatter.Application.Models.Responses;

public sealed record PaginationResponse<T>(int Limit, int TotalCount, List<T> Items);