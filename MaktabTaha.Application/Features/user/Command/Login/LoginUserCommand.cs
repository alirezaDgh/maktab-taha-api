using MaktabTaha.Application.DTO_s.users.login;
using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.user.Command.Login
{
    public class LoginUserCommand : IRequest<OperationResult<LoginDTO>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
