using MaktabTaha.Application.Features.BaseEntities.CaseType;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class CaseTypeController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetCaseTypesList()
    {
        return Ok(await Mediator.Send(new GetCaseTypeListCommand()));
    }
}
