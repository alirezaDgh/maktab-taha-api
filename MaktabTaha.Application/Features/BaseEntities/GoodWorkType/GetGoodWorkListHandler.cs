using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.GoodWorkType.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.GoodWorkType
{
    public class GetGoodWorkTypeListHandler : IRequestHandler<GetGoodWorkTypeListCommand, OperationResult<List<GoodWorkTypeListDTO>>>
    {
        private readonly IGoodWorkTypeRepository _repository;
        private readonly IMapper _mapper;
        public GetGoodWorkTypeListHandler(IGoodWorkTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<GoodWorkTypeListDTO>>> Handle(GetGoodWorkTypeListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<GoodWorkTypeListDTO>>();

            var GoodWorkTypes = await _repository.List();
            var mappedData = _mapper.Map<List<GoodWorkTypeListDTO>>(GoodWorkTypes);
            return operation.Succedded(mappedData);
        }
    }
}
