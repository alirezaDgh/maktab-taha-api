using MaktabTaha.Application.Features.BaseEntities.Area;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace MaktabTaha.WebApi.Controllers.BaseEntities
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetAllAreas()
        {
            return Ok(await Mediator.Send(new GetAreaListCommand()));
        }
    }
}
