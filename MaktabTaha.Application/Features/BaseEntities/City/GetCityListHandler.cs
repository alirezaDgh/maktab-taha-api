using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.City.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.City
{
    public class GetCityListHandler : IRequestHandler<GetCityListCommand, OperationResult<List<CityListDTO>>>
    {
        private readonly ICityRepository _repository;
        private readonly IMapper _mapper;
        public GetCityListHandler(ICityRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<CityListDTO>>> Handle(GetCityListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<CityListDTO>>();

            var Citys = await _repository.GetCityListOfProvince(request.ProvinceId);
            var mappedData = _mapper.Map<List<CityListDTO>>(Citys);
            return operation.Succedded(mappedData);
        }
    }
}
