using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.permission.Query.Single
{
    public class GetPermissionByIdHandler : IRequestHandler<GetPermissionByIdCommand, OperationResult<Permission>>
    {
        private readonly IPermissionRepository _respository;

        public GetPermissionByIdHandler(IPermissionRepository respository)
        {
            _respository = respository;
        }

        public async Task<OperationResult<Permission>> Handle(GetPermissionByIdCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<Permission>();
            var permission = await _respository.FirstOrDefault(x => x.Id == request.Id);
            if (permission == null) return operation.Failure("مجوز یافت نشد");
            return operation.Succedded(permission);
        }
    }
}
