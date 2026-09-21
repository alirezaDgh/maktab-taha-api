using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.permission.Command.Delete
{
    public class DeletePermissionHandler : IRequestHandler<DeletePermissionCommand, OperationResult<bool>>
    {
        private readonly IPermissionRepository _respository;
        private readonly IMapper _mapper;

        public DeletePermissionHandler(IPermissionRepository respository, IMapper mapper)
        {
            _respository = respository;
            _mapper = mapper;
        }

        public async Task<OperationResult<bool>> Handle(DeletePermissionCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<bool>();

            var permission = await _respository.SingleOrDefault(x => x.Id == request.Id);
            if (permission == null) return operation.Failure("مجوز یافت نشد");

            await _respository.Delete(permission);
            return operation.Succedded(true);


        }
    }
}
