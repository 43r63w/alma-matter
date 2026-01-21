namespace Almamatter.Domain.Entities;

public class University
{
    public Guid Id { get; set; }

    public int UniversityCode { get; set; }

    public string Name { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string? Description { get; set; }

    public string City { get; set; } = null!;

    public string Address { get; set; } = null!;
    
    public int Rating { get; set; }

    public string LogoUrl { get; set; } = null!;

    public string WebsiteUrl { get; set; } = null!;
    
    public ICollection<Specialty> Specialties { get; set; } = [];

    public ICollection<Review> Reviews { get; set; } = [];
}