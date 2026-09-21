using MaktabTaha.Application.Features.user_permission.Command.Create;
using MaktabTaha.Application.Features.user_permission.Command.Delete;
using MaktabTaha.Application.Features.user_permission.Command.Update;
using MaktabTaha.Application.Features.user_permission.Query.List;
using MaktabTaha.Application.Features.user_permission.Query.Single;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPermissionController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> CreateUserPermission(CreateUserPermissionCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> UserPermissionList()
        {
            var result = await Mediator.Send(new GetUserPermissionListCommand());
            return Ok(result);
        }
        [HttpGet("{userId}/{permissionId}")]
        public async Task<IActionResult> GetUserPermissionById(int userId, int permissionId)
        {
            var result = await Mediator.Send(new GetUserPermissionByIdCommand() { UserId = userId, PermissionId=permissionId });
            return Ok(result);

        }

        [HttpPut("{userId}/{permissionId}")]
        public async Task<IActionResult> UpdateUserPermission(int userId, int permissionId, UpdateUserPermissionCommand command)
        {
            if (userId != command.UserId && permissionId != command.PermissionId)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{userId}/{permissionId}")]
        public async Task<IActionResult> Delete(int userId, int permissionId)
        {
            return Ok(await Mediator
                .Send(new DeleteUserPermissionCommand { UserId = userId, PermissionId = permissionId }));
        }
    }
}
