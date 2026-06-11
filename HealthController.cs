using Microsoft.AspNetCore.Mvc;

namespace EventFlow.Controllers;

[ApiController]
[Route("api/health")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { Status = "Running", Time = DateTime.UtcNow });
    }
}