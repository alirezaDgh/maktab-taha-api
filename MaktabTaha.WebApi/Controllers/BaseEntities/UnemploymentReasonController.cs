using MaktabTaha.Application.Features.BaseEntities.unemploymentReason.Query.List;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]

public class UnemploymentReasonController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetUnemploymentReasonsList()
    {
        return Ok(await Mediator.Send(new GetUnemploymentReasonListCommand()));
    }
}
