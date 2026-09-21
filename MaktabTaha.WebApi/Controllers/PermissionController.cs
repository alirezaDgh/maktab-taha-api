using MaktabTaha.Application.Features.permission.Command.Create;
using MaktabTaha.Application.Features.permission.Command.Delete;
using MaktabTaha.Application.Features.permission.Command.Update;
using MaktabTaha.Application.Features.permission.Query.List;
using MaktabTaha.Application.Features.permission.Query.Single;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> CreatePermission(CreatePermissionCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> PermissionList()
        {
            var result = await Mediator.Send(new GetPermissionListCommand());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPermissionById(int id)
        {
            var result = await Mediator.Send(new GetPermissionByIdCommand() { Id = id });
            return Ok(result);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePermission(int id, UpdatePermissionCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator
                .Send(new DeletePermissionCommand { Id = id }));
        }
    }
}
