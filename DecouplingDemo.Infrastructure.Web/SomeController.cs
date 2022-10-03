using Microsoft.AspNetCore.Mvc;

namespace DecouplingDemo.Web;

[ApiController]
[Route("/api/v1/some")]
public class SomeController : ControllerBase
{
    public async Task<IActionResult> Test()
    {
        return Ok("It works");
    }
}