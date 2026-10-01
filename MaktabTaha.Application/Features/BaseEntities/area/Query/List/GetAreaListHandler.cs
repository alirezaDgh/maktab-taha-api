using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.area.Query.List
{
    public class GetAreaListHandler : IRequestHandler<GetAreaListCommand, OperationResult<List<Area>>>
    {
        private readonly IAreaRepository _repository;
        public GetAreaListHandler(IAreaRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<Area>>> Handle(GetAreaListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<Area>>();

            var areas = await _repository.List();

            return operation.Succedded(areas);
        }
    }
}
