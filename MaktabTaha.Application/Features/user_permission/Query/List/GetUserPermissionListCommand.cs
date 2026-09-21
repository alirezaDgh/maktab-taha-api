using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.user_permission.Query.List
{
    public class GetUserPermissionListCommand : IRequest<OperationResult<List<UserPermission>>>
    {
    }
}
