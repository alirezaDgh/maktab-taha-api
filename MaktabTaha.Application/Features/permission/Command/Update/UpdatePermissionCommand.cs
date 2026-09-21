using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.permission.Command.Update
{
    public class UpdatePermissionCommand : IRequest<OperationResult<Permission>>
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
