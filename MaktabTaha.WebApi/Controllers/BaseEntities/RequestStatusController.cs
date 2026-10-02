using MaktabTaha.Application.Features.BaseEntities.religon.Query.List;
using MaktabTaha.Application.Features.BaseEntities.requestStatus.Query.List;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestStatusController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetRequestStatusList()
        {
            return Ok(await Mediator.Send(new GetRequestStatusListCommand()));
        }
    }
}
