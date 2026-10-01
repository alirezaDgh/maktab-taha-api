using MaktabTaha.Application.Features.BaseEntities.charityMainRole;
using MaktabTaha.Application.Features.BaseEntities.charityMainRole.Query.List;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class CharityMainRoleController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetCharityMainRolesList()
    {
        return Ok(await Mediator.Send(new GetCharityMainRoleListCommand()));
    }
}
