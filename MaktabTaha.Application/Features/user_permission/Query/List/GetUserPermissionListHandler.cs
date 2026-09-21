using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.user_permission.Query.List
{
    public class GetUserPermissionListHandler : IRequestHandler<GetUserPermissionListCommand, OperationResult<List<UserPermission>>>
    {
        private readonly IUserPermissionRepository _respository;

        public GetUserPermissionListHandler(IUserPermissionRepository respository)
        {
            _respository = respository;
        }

        public async Task<OperationResult<List<UserPermission>>> Handle(GetUserPermissionListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<UserPermission>>();
            var permissions = await _respository.GetListWithoutIsDeleted();

            return operation.Succedded(permissions);
        }
    }
}
