using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.OrphanStatus.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.OrphanStatus
{
    public class GetOrphanStatusListHandler : IRequestHandler<GetOrphanStatusListCommand, OperationResult<List<OrphanStatusListDTO>>>
    {
        private readonly IOrphanStatusRepository _repository;
        private readonly IMapper _mapper;
        public GetOrphanStatusListHandler(IOrphanStatusRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<OrphanStatusListDTO>>> Handle(GetOrphanStatusListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<OrphanStatusListDTO>>();

            var OrphanStatuss = await _repository.List();
            var mappedData = _mapper.Map<List<OrphanStatusListDTO>>(OrphanStatuss);
            return operation.Succedded(mappedData);
        }
    }
}
