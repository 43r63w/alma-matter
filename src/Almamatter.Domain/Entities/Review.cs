namespace Almamatter.Domain.Entities;

public class Review
{
    public Guid Id { get; set; }

    public string Author { get; set; } = null!;

    public string Content { get; set; } = null!;

    public int Assessment { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int RatingInfrastructure { get; set; }

    public int RatingTeaching { get; set; }

    public int RatingAtmosphere { get; set; }

    public int Like { get; set; }

    public University University { get; set; } = null!;
    public Guid UniversityId { get; set; }
}