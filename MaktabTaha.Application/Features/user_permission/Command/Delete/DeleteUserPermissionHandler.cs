using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;

namespace MaktabTaha.Application.Features.user_permission.Command.Delete
{
    public class DeleteUserPermissionHandler : IRequestHandler<DeleteUserPermissionCommand, OperationResult<bool>>
    {
        private readonly IUserPermissionRepository _respository;
        private readonly IMapper _mapper;

        public DeleteUserPermissionHandler(IUserPermissionRepository respository, IMapper mapper)
        {
            _respository = respository;
            _mapper = mapper;
        }

        public async Task<OperationResult<bool>> Handle(DeleteUserPermissionCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<bool>();

            var userPermission = await _respository.SingleOrDefault(x => x.UserId == request.UserId && x.PermissionId == request.PermissionId);
            if (userPermission == null) return operation.Failure("مجوز یافت نشد");

            await _respository.Delete(userPermission);
            return operation.Succedded(true);


        }
    }
}
