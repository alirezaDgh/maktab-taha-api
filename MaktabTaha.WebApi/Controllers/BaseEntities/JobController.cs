using MaktabTaha.Application.Features.BaseEntities.Job;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class JobController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetJobsList()
    {
        return Ok(await Mediator.Send(new GetJobListCommand()));
    }
}
