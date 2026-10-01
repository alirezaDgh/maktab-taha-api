using AutoMapper;
using MaktabTaha.Application.Features.BaseEntities.physicalStatus.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.physicalStatus.Query.List
{
    public class GetPhysicalStatusListHandler : IRequestHandler<GetPhysicalStatusListCommand, OperationResult<List<PhysicalStatus>>>
    {
        private readonly IPhysicalStatusRepository _repository;
        public GetPhysicalStatusListHandler(IPhysicalStatusRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<PhysicalStatus>>> Handle(GetPhysicalStatusListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<PhysicalStatus>>();

            var PhysicalStatuss = await _repository.List();

            return operation.Succedded(PhysicalStatuss);
        }
    }
}
