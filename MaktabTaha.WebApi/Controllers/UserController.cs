using MaktabTaha.Application.Features.user.Command.Create;
using MaktabTaha.Application.Features.user.Command.delete;
using MaktabTaha.Application.Features.user.Command.Login;
using MaktabTaha.Application.Features.user.Command.update;
using MaktabTaha.Application.Features.user.Query.List;
using MaktabTaha.Application.Features.user.Query.single;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> UserList()
        {
            var result = await Mediator.Send(new GetUserListCommand());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var result = await Mediator.Send(new GetUserByIdCommand() { Id = id });
            return Ok(result);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, UpdateUserCommand command)
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
                .Send(new DeleteUserCommand { Id = id }));
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginUser(LoginUserCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
