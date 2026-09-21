using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.user_permission.Command.Create
{
    public class CreateUserPermissionHandler : IRequestHandler<CreateUserPermissionCommand, OperationResult<UserPermission>>
    {
        private readonly IUserPermissionRepository _respository;
        private readonly IMapper _mapper;

        public CreateUserPermissionHandler(IUserPermissionRepository respository, IMapper mapper)
        {
            _respository = respository;
            _mapper = mapper;
        }

        public async Task<OperationResult<UserPermission>> Handle(CreateUserPermissionCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<UserPermission>();

            var mapped = _mapper.Map<UserPermission>(request);
            await _respository.Create(mapped);
            return operation.Succedded(mapped);
        }
    }
}
