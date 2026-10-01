using MaktabTaha.Application.Features.BaseEntities.houseHeadStatus;
using MaktabTaha.Application.Features.BaseEntities.houseHeadStatus.Query.List;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class HouseHeadStatusController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetHouseHeadStatussList()
    {
        return Ok(await Mediator.Send(new GetHouseHeadStatusListCommand()));
    }
}
