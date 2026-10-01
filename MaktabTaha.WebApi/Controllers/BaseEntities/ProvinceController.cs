using MaktabTaha.Application.Features.BaseEntities.province.Query.List;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class ProvinceController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetProvincesList()
    {
        return Ok(await Mediator.Send(new GetProvinceListCommand()));
    }
}
