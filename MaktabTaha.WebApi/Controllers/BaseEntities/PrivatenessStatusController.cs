using MaktabTaha.Application.Features.BaseEntities.PrivatenessStatus;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class PrivatenessStatusController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetPrivatenessStatussList()
    {
        return Ok(await Mediator.Send(new GetPrivatenessStatusListCommand()));
    }
}
