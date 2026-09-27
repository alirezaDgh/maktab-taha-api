using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.Province.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.Province
{
    public class GetProvinceListHandler : IRequestHandler<GetProvinceListCommand, OperationResult<List<ProvinceListDTO>>>
    {
        private readonly IProvinceRepository _repository;
        private readonly IMapper _mapper;
        public GetProvinceListHandler(IProvinceRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<ProvinceListDTO>>> Handle(GetProvinceListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<ProvinceListDTO>>();

            var Provinces = await _repository.List();
            var mappedData = _mapper.Map<List<ProvinceListDTO>>(Provinces);
            return operation.Succedded(mappedData);
        }
    }
}
