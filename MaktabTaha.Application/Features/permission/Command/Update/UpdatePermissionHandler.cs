using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.permission.Command.Update
{
    public class UpdatePermissionHandler : IRequestHandler<UpdatePermissionCommand, OperationResult<Permission>>
    {
        private readonly IPermissionRepository _respository;
        private readonly IMapper _mapper;

        public UpdatePermissionHandler(IPermissionRepository respository, IMapper mapper)
        {
            _respository = respository;
            _mapper = mapper;
        }

        public async Task<OperationResult<Permission>> Handle(UpdatePermissionCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<Permission>();
            var permission = await _respository.FirstOrDefault(x => x.Id == request.Id);
            if (permission == null) return operation.Failure("مجوز یافت نشد");
            _mapper.Map(request, permission);

            await _respository.Update(permission);
            return operation.Succedded(permission);



        }
    }
}
