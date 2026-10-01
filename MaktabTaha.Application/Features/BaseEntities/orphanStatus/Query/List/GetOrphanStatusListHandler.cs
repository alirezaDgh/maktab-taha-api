using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.orphanStatus.Query.List
{
    public class GetOrphanStatusListHandler : IRequestHandler<GetOrphanStatusListCommand, OperationResult<List<OrphanStatus>>>
    {
        private readonly IOrphanStatusRepository _repository;
        public GetOrphanStatusListHandler(IOrphanStatusRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<OrphanStatus>>> Handle(GetOrphanStatusListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<OrphanStatus>>();

            var OrphanStatuss = await _repository.List();

            return operation.Succedded(OrphanStatuss);
        }
    }
}
