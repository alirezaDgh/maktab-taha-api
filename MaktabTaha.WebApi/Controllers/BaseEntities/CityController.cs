using MaktabTaha.Application.Features.BaseEntities.City;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class CityController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetCitiesList()
    {
        return Ok(await Mediator.Send(new GetCityListCommand()));
    }
}
