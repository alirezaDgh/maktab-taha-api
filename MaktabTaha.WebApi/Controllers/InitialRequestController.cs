using MaktabTaha.Application.Features.initialRequest.Command.Approve;
using MaktabTaha.Application.Features.initialRequest.Command.Create;
using MaktabTaha.Application.Features.initialRequest.Command.Delete;
using MaktabTaha.Application.Features.initialRequest.Command.Update;
using MaktabTaha.Application.Features.initialRequest.Query.List;
using MaktabTaha.Application.Features.initialRequest.Query.Single;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace MaktabTaha.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InitialRequestController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> CreateInitialRequest(CreateInitialRequestCommand command)
        {
            var request = await Mediator.Send(command);
            return Ok(request);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateInitialRequest(int id, UpdateInitialRequestCommand command)
        {
            if (id != command.RequestNumber)
                return BadRequest();
            
            return Ok(await Mediator.Send(command));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllInitialRequests()
        {
            var request = await Mediator.Send(new GetInitialRequestListCommand());
            return Ok(request);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetInitialRequestById(int id, GetInitialRequestByIdCommand command)
        {
            if (id != command.RequestNumber) 
                return BadRequest();

            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInitialRequest(int id)
        {
            return Ok(await Mediator.Send(new DeleteInitialRequestCommand{RequestNumber = id}));
        }

        [HttpPost]
        public async Task<IActionResult> ApproveInitialRequest(ApproveInitialRequestCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
