using Almamatter.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Almamatter.Api.Exstensions;

public static class ApplyMigrations
{
    public static async Task AddMigrationsAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();   
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        await dbContext.Database.MigrateAsync();
    }
}