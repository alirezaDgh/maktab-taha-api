using MaktabTaha.Application.Features.BaseEntities.Religon;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class ReligonController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetReligonsList()
    {
        return Ok(await Mediator.Send(new GetReligonListCommand()));
    }
}
