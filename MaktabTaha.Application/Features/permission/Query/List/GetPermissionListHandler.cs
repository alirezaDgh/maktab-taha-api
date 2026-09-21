using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.permission.Query.List
{
    public class GetPermissionListHandler : IRequestHandler<GetPermissionListCommand, OperationResult<List<Permission>>>
    {
        private readonly IPermissionRepository _respository;

        public GetPermissionListHandler(IPermissionRepository respository)
        {
            _respository = respository;
        }

        public async Task<OperationResult<List<Permission>>> Handle(GetPermissionListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<Permission>>();
            var permissions = await _respository.List();

            return operation.Succedded(permissions);
        }
    }
}
