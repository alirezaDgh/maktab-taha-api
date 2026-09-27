using MaktabTaha.Application.Features.BaseEntities.Area;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class AreaController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetAreasList()
    {
        return Ok(await Mediator.Send(new GetAreaListCommand()));
    }
}
