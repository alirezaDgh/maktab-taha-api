using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.PhysicalStatus.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.PhysicalStatus
{
    public class GetPhysicalStatusListHandler : IRequestHandler<GetPhysicalStatusListCommand, OperationResult<List<PhysicalStatusListDTO>>>
    {
        private readonly IPhysicalStatusRepository _repository;
        private readonly IMapper _mapper;
        public GetPhysicalStatusListHandler(IPhysicalStatusRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<PhysicalStatusListDTO>>> Handle(GetPhysicalStatusListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<PhysicalStatusListDTO>>();

            var PhysicalStatuss = await _repository.List();
            var mappedData = _mapper.Map<List<PhysicalStatusListDTO>>(PhysicalStatuss);
            return operation.Succedded(mappedData);
        }
    }
}
