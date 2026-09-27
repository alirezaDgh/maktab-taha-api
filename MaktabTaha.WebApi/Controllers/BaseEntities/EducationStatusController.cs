using MaktabTaha.Application.Features.BaseEntities.EducationStatus;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class EducationalStatusController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetEducationalStatussList()
    {
        return Ok(await Mediator.Send(new GetEducationStatusListCommand()));
    }
}
