namespace Almamatter.Application.Models.Responses;

public sealed record CreateUniversityResponse(string Name, bool IsSuccess, string? Message);