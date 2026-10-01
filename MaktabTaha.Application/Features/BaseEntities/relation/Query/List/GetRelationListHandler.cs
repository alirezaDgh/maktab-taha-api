using AutoMapper;
using MaktabTaha.Application.Features.BaseEntities.relation.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.relation.Query.List
{
    public class GetRelationListHandler : IRequestHandler<GetRelationListCommand, OperationResult<List<Relation>>>
    {
        private readonly IRelationRepository _repository;
        public GetRelationListHandler(IRelationRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<Relation>>> Handle(GetRelationListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<Relation>>();

            var Relations = await _repository.List();

            return operation.Succedded(Relations);
        }
    }
}
