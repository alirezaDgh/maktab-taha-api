using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.user_permission.Command.Delete
{
    public class DeleteUserPermissionCommand : IRequest<OperationResult<bool>>
    {
        public int UserId { get; set; }
        public int PermissionId { get; set; }
    }
}
