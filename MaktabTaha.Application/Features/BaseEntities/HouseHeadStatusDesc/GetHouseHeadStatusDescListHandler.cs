using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.HouseHeadStatusDesc.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.HouseHeadStatusDesc
{
    public class GetHouseHeadStatusDescListHandler : IRequestHandler<GetHouseHeadStatusDescListCommand, OperationResult<List<HouseHeadStatusDescListDTO>>>
    {
        private readonly IHouseHeadStatusDescRepository _repository;
        private readonly IMapper _mapper;
        public GetHouseHeadStatusDescListHandler(IHouseHeadStatusDescRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<HouseHeadStatusDescListDTO>>> Handle(GetHouseHeadStatusDescListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<HouseHeadStatusDescListDTO>>();

            var HouseHeadStatusDescs = await _repository.List();
            var mappedData = _mapper.Map<List<HouseHeadStatusDescListDTO>>(HouseHeadStatusDescs);
            return operation.Succedded(mappedData);
        }
    }
}
