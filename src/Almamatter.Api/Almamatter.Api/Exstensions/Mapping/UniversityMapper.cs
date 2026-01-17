using Almamatter.Api.Contracts;
using Almamatter.Application.Models.University;

namespace Almamatter.Api.Exstensions.Mapping;

public static class UniversityMapper
{
    public static CreateUniversityModel ToUniversityModel(this CreateUniversityRequest request)
    {
        return new CreateUniversityModel(
            request.Name,
            request.Description,
            request.City,
            request.Rating,
            request.LogoUrl,
            request.WebsiteUrl);
    }
}