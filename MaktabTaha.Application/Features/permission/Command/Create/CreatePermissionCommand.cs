using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.permission.Command.Create
{
    public class CreatePermissionCommand : IRequest<OperationResult<Permission>>
    {
        public string Title { get; set; }
    }
}
