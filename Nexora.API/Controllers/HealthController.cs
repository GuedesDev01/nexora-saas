using Microsoft.AspNetCore.Mvc;

namespace Nexora.API.Controllers;

[ApiController]
[Route("api/health")]
public class HealthController : ControllerBase
{

    [HttpGet]
    public IActionResult GetHealthStatus()

    {
        return Ok("Nexora API está viva");
    }
}