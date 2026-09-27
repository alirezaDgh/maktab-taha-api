using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.Area.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.Area
{
    public class GetAreaListHandler : IRequestHandler<GetAreaListCommand, OperationResult<List<AreaListDTO>>>
    {
        private readonly IAreaRepository _repository;
        private readonly IMapper _mapper;
        public GetAreaListHandler(IAreaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<AreaListDTO>>> Handle(GetAreaListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<AreaListDTO>>();

            var areas = await _repository.List();
            var mappedData = _mapper.Map<List<AreaListDTO>>(areas);
            return operation.Succedded(mappedData);
        }
    }
}
