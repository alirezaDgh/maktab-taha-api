using AutoMapper;
using MaktabTaha.Application.Features.BaseEntities.city.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.city.Query.List
{
    public class GetCityListHandler : IRequestHandler<GetCityListCommand, OperationResult<List<City>>>
    {
        private readonly ICityRepository _repository;
        public GetCityListHandler(ICityRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<City>>> Handle(GetCityListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<City>>();

            var cities = await _repository.GetCityListOfProvince(request.ProvinceId);

            return operation.Succedded(cities);
        }
    }
}
