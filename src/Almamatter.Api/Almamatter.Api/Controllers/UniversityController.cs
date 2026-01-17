using Almamatter.Api.Contracts;
using Almamatter.Api.Exstensions.Mapping;
using Almamatter.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Almamatter.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class UniversityController(IUniversityService universityService) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> CreateUniversityAsync(
        [FromBody] CreateUniversityRequest request,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(request.Author))
            return BadRequest("Fill author field");

        var model = request.ToUniversityModel();

        var response = await universityService.CreateUniversityAsync(model, cancellationToken);
        if (!response.IsSuccess)
            return BadRequest(response);
        
        
        return Ok(response);
    }
}