using Microsoft.AspNetCore.Mvc;

namespace NotionProjectApi.Controllers;

[ApiController]
[Route("Admin")]
public class AdminController: ControllerBase
{
    [HttpPost("Login")]
    public async Task<IActionResult> Login()
    {
        return Ok();
    }
}