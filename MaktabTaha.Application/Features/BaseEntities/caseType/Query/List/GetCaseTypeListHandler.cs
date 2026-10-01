using AutoMapper;
using MaktabTaha.Application.Features.BaseEntities.caseType.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.caseType.Query.List
{
    public class GetCaseTypeListHandler : IRequestHandler<GetCaseTypeListCommand, OperationResult<List<CaseType>>>
    {
        private readonly ICaseTypeRepository _repository;
        public GetCaseTypeListHandler(ICaseTypeRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<CaseType>>> Handle(GetCaseTypeListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<CaseType>>();

            var CaseTypes = await _repository.List();

            return operation.Succedded(CaseTypes);
        }
    }
}
