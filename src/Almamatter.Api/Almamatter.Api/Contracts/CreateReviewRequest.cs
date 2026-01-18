using System.ComponentModel.DataAnnotations;

namespace Almamatter.Api.Contracts;

public sealed record CreateReviewRequest(
    [Required] string Author,
    [Required] string Content,
    [Required] int Assessment,
    [Required] int RatingInfrastructure,
    [Required] int RatingTeaching,
    [Required] int RatingAtmosphere,
    [Required] Guid UniversityId);