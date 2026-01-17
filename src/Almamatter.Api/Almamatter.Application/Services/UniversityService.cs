namespace Almamatter.Application.Services;

public sealed class UniversityService(ApplicationDbContext dbContext) : IUniversityService
{
    public async Task<CreateUniversityResponse> CreateUniversityAsync(
        CreateUniversityModel model,
        CancellationToken cancellationToken)
    {
        var toEntity = model.ToEntity();

        dbContext.Universities.Add(toEntity);
        var response = await dbContext.SaveChangesAsync(cancellationToken);

        return response == 0
            ? new CreateUniversityResponse(toEntity.Name, false, null)
            : new CreateUniversityResponse(toEntity.Name, true,"Після проходження модерації ваш університет з'явиться у списку");
    }
}