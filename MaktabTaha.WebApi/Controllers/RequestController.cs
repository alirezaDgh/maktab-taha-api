using MaktabTaha.Application.Features.request.Command.Approve;
using MaktabTaha.Application.Features.request.Command.Create;
using MaktabTaha.Application.Features.request.Command.Delete;
using MaktabTaha.Application.Features.request.Command.Update;
using MaktabTaha.Application.Features.request.Query.List;
using MaktabTaha.Application.Features.request.Query.Single;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

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
        public async Task<IActionResult> GetAllRequests()
        {
            var request = await Mediator.Send(new GetRequestListCommand());
            return Ok(request);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRequestById(int id, GetRequestByIdCommand command)
        {
            if (id != command.Id) 
                return BadRequest();

            return Ok(await Mediator.Send(command));
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
