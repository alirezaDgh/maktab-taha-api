using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.unemploymentReason.Query.List
{
    public class GetUnemploymentReasonListHandler : IRequestHandler<GetUnemploymentReasonListCommand, OperationResult<List<UnemploymentReason>>>
    {
        private readonly IUnemploymentReasonRepository _repository;
        public GetUnemploymentReasonListHandler(IUnemploymentReasonRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<UnemploymentReason>>> Handle(GetUnemploymentReasonListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<UnemploymentReason>>();

            var UnemploymentReasons = await _repository.List();

            return operation.Succedded(UnemploymentReasons);
        }
    }
}
