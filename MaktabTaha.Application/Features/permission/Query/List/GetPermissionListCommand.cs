using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.permission.Query.List
{
    public class GetPermissionListCommand : IRequest<OperationResult<List<Permission>>>
    {
    }
}
