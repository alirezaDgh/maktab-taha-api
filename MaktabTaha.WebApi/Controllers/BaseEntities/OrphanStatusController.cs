using MaktabTaha.Application.Features.BaseEntities.OrphanStatus;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class OrphanStatusController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetOrphanStatussList()
    {
        return Ok(await Mediator.Send(new GetOrphanStatusListCommand()));
    }
}
