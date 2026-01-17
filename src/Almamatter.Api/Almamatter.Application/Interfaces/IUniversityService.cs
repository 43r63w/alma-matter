namespace Almamatter.Application.Interfaces;

public interface IUniversityService
{
    Task<CreateUniversityResponse> CreateUniversityAsync(
        CreateUniversityModel model,
        CancellationToken cancellationToken);
}