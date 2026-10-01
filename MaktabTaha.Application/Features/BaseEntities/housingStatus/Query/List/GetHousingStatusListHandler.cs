using AutoMapper;
using MaktabTaha.Application.Features.BaseEntities.housingStatus.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.housingStatus.Query.List
{
    public class GetHousingStatusListHandler : IRequestHandler<GetHousingStatusListCommand, OperationResult<List<HousingStatus>>>
    {
        private readonly IHousingStatusRepository _repository;
        public GetHousingStatusListHandler(IHousingStatusRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<HousingStatus>>> Handle(GetHousingStatusListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<HousingStatus>>();

            var HousingStatuss = await _repository.List();

            return operation.Succedded(HousingStatuss);
        }
    }
}
