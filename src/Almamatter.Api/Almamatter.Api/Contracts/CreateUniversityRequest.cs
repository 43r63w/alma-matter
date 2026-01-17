namespace Almamatter.Api.Contracts;

public sealed record CreateUniversityRequest(
    string Author,
    string Name,
    string? Description,
    string City,
    int Rating,
    string LogoUrl,
    string WebsiteUrl);