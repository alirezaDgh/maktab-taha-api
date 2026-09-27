using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.HouseHeadStatus.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.HouseHeadStatus
{
    public class GetHouseHeadStatusListHandler : IRequestHandler<GetHouseHeadStatusListCommand, OperationResult<List<HouseHeadStatusListDTO>>>
    {
        private readonly IHouseHeadStatusRepository _repository;
        private readonly IMapper _mapper;
        public GetHouseHeadStatusListHandler(IHouseHeadStatusRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<HouseHeadStatusListDTO>>> Handle(GetHouseHeadStatusListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<HouseHeadStatusListDTO>>();

            var HouseHeadStatuss = await _repository.List();
            var mappedData = _mapper.Map<List<HouseHeadStatusListDTO>>(HouseHeadStatuss);
            return operation.Succedded(mappedData);
        }
    }
}
