using Almamatter.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Almamatter.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Review> Reviews { get; set; }

    public DbSet<Specialty> Specialties { get; set; }

    public DbSet<University> Universities { get; set; }

    public DbSet<UniversitySpecialty> UniversitySpecialties { get; set; }
}