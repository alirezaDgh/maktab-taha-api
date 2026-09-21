using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.permission.Command.Delete
{
    public class DeletePermissionCommand : IRequest<OperationResult<bool>>
    {
        public int Id { get; set; }
    }
}
