namespace Almamatter.Domain.Entities;

public class University
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string City { get; set; } = null!;

    public int Rating { get; set; }

    public string LogoUrl { get; set; } = null!;

    public string WebsiteUrl { get; set; } = null!;

    public bool Accepted { get; set; }

    public ICollection<Specialty> Specialties { get; set; } = [];

    public ICollection<Review> Reviews { get; set; } = [];
}