using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.HousingStatus.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.HousingStatus
{
    public class GetHousingStatusListHandler : IRequestHandler<GetHousingStatusListCommand, OperationResult<List<HousingStatusListDTO>>>
    {
        private readonly IHousingStatusRepository _repository;
        private readonly IMapper _mapper;
        public GetHousingStatusListHandler(IHousingStatusRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<HousingStatusListDTO>>> Handle(GetHousingStatusListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<HousingStatusListDTO>>();

            var HousingStatuss = await _repository.List();
            var mappedData = _mapper.Map<List<HousingStatusListDTO>>(HousingStatuss);
            return operation.Succedded(mappedData);
        }
    }
}
