using MaktabTaha.Application.Features.BaseEntities.city.Query.List;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class CityController : BaseApiController
{
    [HttpGet("{provinceId}")]
    public async Task<IActionResult> GetCitiesList(int provinceId)
    {
        var result = await Mediator.Send(new GetCityListCommand() { ProvinceId = provinceId });
        return Ok(result);
    }
}
