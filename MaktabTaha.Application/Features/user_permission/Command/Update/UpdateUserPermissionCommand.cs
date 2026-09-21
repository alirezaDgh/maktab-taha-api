using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.user_permission.Command.Update
{
    public class UpdateUserPermissionCommand : IRequest<OperationResult<UserPermission>>
    {
        public int UserId { get; set; }
        public int PermissionId { get; set; }
    }
}
