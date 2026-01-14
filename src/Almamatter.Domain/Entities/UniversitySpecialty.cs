namespace Almamatter.Domain.Entities;

public class UniversitySpecialty
{
    public Guid UniversitySpecialtyId { get; set; }
    public Specialty Specialty { get; set; } = null!;

    public Guid UniversityId { get; set; }
    public University University { get; set; } = null!;

    public decimal ContractPrice { get; set; }
}