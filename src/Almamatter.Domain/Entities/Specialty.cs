namespace Almamatter.Domain.Entities;

public class Specialty
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public int Code { get; set; }

    public decimal Price { get; set; }

    public int Rating { get; set; }

    public ICollection<UniversitySpecialty> Specialties { get; set; } = [];
}