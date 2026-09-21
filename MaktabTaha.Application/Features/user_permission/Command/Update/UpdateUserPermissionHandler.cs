using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.user_permission.Command.Update
{
    public class UpdateUserPermissionHandler : IRequestHandler<UpdateUserPermissionCommand, OperationResult<UserPermission>>
    {
        private readonly IUserPermissionRepository _respository;
        private readonly IMapper _mapper;

        public UpdateUserPermissionHandler(IUserPermissionRepository respository, IMapper mapper)
        {
            _respository = respository;
            _mapper = mapper;
        }

        public async Task<OperationResult<UserPermission>> Handle(UpdateUserPermissionCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<UserPermission>();
            var userPermission = await _respository.SingleOrDefault(x => x.UserId == request.UserId && x.PermissionId == request.PermissionId);
            if (userPermission == null) return operation.Failure("مجوز یافت نشد");
            _mapper.Map(request, userPermission);

            await _respository.Update(userPermission);
            return operation.Succedded(userPermission);



        }
    }
}
