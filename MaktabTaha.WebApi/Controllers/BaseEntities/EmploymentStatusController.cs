using MaktabTaha.Application.Features.BaseEntities.EmploymentStatus;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class EmploymentStatusController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetEmploymentStatussList()
    {
        return Ok(await Mediator.Send(new GetEmploymentStatusListCommand()));
    }
}
