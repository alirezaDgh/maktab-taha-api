using MaktabTaha.Application.DTO_s.users.create;
using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.user.Command.Create
{
    public class CreateUserCommand : IRequest<OperationResult<CreateUserDTO>>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public int RoleId { get; set; }


    }
}
