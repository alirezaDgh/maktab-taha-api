using MaktabTaha.Application.DTO_s.Requests.Search;
using MaktabTaha.Application.Features.request.Command.Approve;
using MaktabTaha.Application.Features.request.Command.Create;
using MaktabTaha.Application.Features.request.Command.Delete;
using MaktabTaha.Application.Features.request.Command.Update;
using MaktabTaha.Application.Features.request.Query.List;
using MaktabTaha.Application.Features.request.Query.Single;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MaktabTaha.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> CreateRequest(CreateRequestCommand command)
        {
            var request = await Mediator.Send(command);
            return Ok(request);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRequest(int id, UpdateRequestCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            
            return Ok(await Mediator.Send(command));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRequests([FromBody] SearchRequestListDTO filters)
        {
            var request = await Mediator.Send(new GetRequestListCommand{

                Filters = filters
            });

            return Ok(request);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRequestById(int id)
        {
            return Ok(await Mediator.Send(new GetRequestByIdCommand { Id = id }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequest(int id)
        {
            return Ok(await Mediator.Send(new DeleteRequestCommand{Id = id}));
        }

        [HttpPost("approve")]
        public async Task<IActionResult> ApproveRequest(ApproveRequestCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
