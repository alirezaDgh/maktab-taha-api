using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.user_permission.Query.Single
{
    public class GetUserPermissionByIdHandler : IRequestHandler<GetUserPermissionByIdCommand, OperationResult<UserPermission>>
    {
        private readonly IUserPermissionRepository _respository;

        public GetUserPermissionByIdHandler(IUserPermissionRepository respository)
        {
            _respository = respository;
        }

        public async Task<OperationResult<UserPermission>> Handle(GetUserPermissionByIdCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<UserPermission>();
            var userPermission = await _respository.SingleOrDefault(x => x.UserId == request.UserId && x.PermissionId == request.PermissionId);
            if (userPermission == null) return operation.Failure("مجوز یافت نشد");
            return operation.Succedded(userPermission);
        }
    }
}
