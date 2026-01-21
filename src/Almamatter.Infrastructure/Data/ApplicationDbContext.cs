using Almamatter.Domain.Entities;
using Almamatter.Infrastructure.Data.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Almamatter.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Review> Reviews { get; set; }

    public DbSet<Specialty> Specialties { get; set; }

    public DbSet<University> Universities { get; set; }

    public DbSet<UniversitySpecialty> UniversitySpecialties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        var connectionString = Environment.GetEnvironmentVariable("DefaultDbConnection");

        try
        {
            optionsBuilder
           .UseSqlServer(connectionString)
           .UseAsyncSeeding(async (context, _, cancellationToken) =>
           {
               await DbInitializer.SeedAsync(context, cancellationToken);
           });
        }
        catch (Exception ex)
        {
            throw new Exception("Failed to configure the database context.", ex);
        }

    }

}