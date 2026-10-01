using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.goodWorkType.Query.List
{
    public class GetGoodWorkTypeListHandler : IRequestHandler<GetGoodWorkTypeListCommand, OperationResult<List<GoodWorkType>>>
    {
        private readonly IGoodWorkTypeRepository _repository;

        public GetGoodWorkTypeListHandler(IGoodWorkTypeRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<GoodWorkType>>> Handle(GetGoodWorkTypeListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<GoodWorkType>>();

            var GoodWorkTypes = await _repository.List();
            
            return operation.Succedded(GoodWorkTypes);
        }
    }
}
