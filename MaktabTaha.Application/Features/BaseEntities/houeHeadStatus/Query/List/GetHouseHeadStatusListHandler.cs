using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.houseHeadStatus.Query.List
{
    public class GetHouseHeadStatusListHandler : IRequestHandler<GetHouseHeadStatusListCommand, OperationResult<List<HouseHeadStatus>>>
    {
        private readonly IHouseHeadStatusRepository _repository;
        public GetHouseHeadStatusListHandler(IHouseHeadStatusRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<HouseHeadStatus>>> Handle(GetHouseHeadStatusListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<HouseHeadStatus>>();

            var HouseHeadStatuss = await _repository.List();

            return operation.Succedded(HouseHeadStatuss);
        }
    }
}
