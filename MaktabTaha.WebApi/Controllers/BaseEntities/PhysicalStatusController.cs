using MaktabTaha.Application.Features.BaseEntities.PhysicalStatus;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class PhysicalStatusController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetPhysicalStatussList()
    {
        return Ok(await Mediator.Send(new GetPhysicalStatusListCommand()));
    }
}
