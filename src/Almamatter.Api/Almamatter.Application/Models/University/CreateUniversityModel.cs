namespace Almamatter.Application.Models.University;

public sealed record CreateUniversityModel(
    string Name,
    string? Description,
    string City,
    int Rating,
    string LogoUrl,
    string WebsiteUrl);