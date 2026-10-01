using MaktabTaha.Application.Features.BaseEntities.requestType.Query.List;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class RequestTypeController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetRequestTypesList()
    {
        return Ok(await Mediator.Send(new GetRequestTypeListCommand()));
    }
}
