using MaktabTaha.Application.DTOs.users.create;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.user.Command.Create
{
    public class CreateUserCommand : IRequest<OperationResult<User>>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }

    }
}
