using MaktabTaha.Application.Features.BaseEntities.housingStatus.Query.List;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class HousingStatusController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetHousingStatussList()
    {
        return Ok(await Mediator.Send(new GetHousingStatusListCommand()));
    }
}
