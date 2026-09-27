using MaktabTaha.Application.Features.BaseEntities.HouseHeadStatusDesc;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class HouseHeadStatusDescController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetHouseHeadStatusDescsList()
    {
        return Ok(await Mediator.Send(new GetHouseHeadStatusDescListCommand()));
    }
}
