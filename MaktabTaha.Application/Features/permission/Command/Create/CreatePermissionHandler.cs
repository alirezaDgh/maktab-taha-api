using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.permission.Command.Create
{
    public class CreatePermissionHandler : IRequestHandler<CreatePermissionCommand, OperationResult<Permission>>
    {
        private readonly IPermissionRepository _respository;
        private readonly IMapper _mapper;

        public CreatePermissionHandler(IPermissionRepository respository, IMapper mapper)
        {
            _respository = respository;
            _mapper = mapper;
        }

        public async Task<OperationResult<Permission>> Handle(CreatePermissionCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<Permission>();

            var permission = await _respository.SingleOrDefault(x => x.Title == request.Title);
            if (permission != null) return operation.Failure("مجوز با این نام قبلا ثبت شده است");

            var mapped = _mapper.Map<Permission>(request);
            await _respository.Create(mapped);
            return operation.Succedded(mapped);
        }
    }
}
