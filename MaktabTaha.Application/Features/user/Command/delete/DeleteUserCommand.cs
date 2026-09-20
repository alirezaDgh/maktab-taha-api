using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.user.Command.delete
{
    public class DeleteUserCommand : IRequest<OperationResult<bool>>
    {
        public int Id { get; set; }
    }
}
