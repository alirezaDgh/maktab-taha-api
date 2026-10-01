using MaktabTaha.Application.Features.BaseEntities.relation.Query.List;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class RelationController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetRelationsList()
    {
        return Ok(await Mediator.Send(new GetRelationListCommand()));
    }
}
