using MaktabTaha.Application.DTOs.users.update;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.user.Command.update
{
    public class UpdateUserCommand : IRequest<OperationResult<User>>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }

    }
}
