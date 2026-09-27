using MaktabTaha.Application.Features.BaseEntities.Nationality;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class NationalityController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetNationalitysList()
    {
        return Ok(await Mediator.Send(new GetNationalityListCommand()));
    }
}
