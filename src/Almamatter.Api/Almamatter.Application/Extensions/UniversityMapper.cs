using Almamatter.Domain.Entities;

namespace Almamatter.Application.Extensions;

public static class UniversityMapper
{
    public static University ToEntity(this CreateUniversityModel model)
    {
        return new University
        {
            Id = Guid.NewGuid(),
            Name = model.Name,
            City = model.City,
            Description = model.Description,
            LogoUrl = model.LogoUrl,
            WebsiteUrl = model.WebsiteUrl,
            Rating = model.Rating,
            Accepted = false,
            Reviews = [],
            Specialties = []
        };
    }
}