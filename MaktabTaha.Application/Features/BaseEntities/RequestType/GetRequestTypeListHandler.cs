using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.RequestType.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.RequestType
{
    public class GetRequestTypeListHandler : IRequestHandler<GetRequestTypeListCommand, OperationResult<List<RequestTypeListDTO>>>
    {
        private readonly IRequestTypeRepository _repository;
        private readonly IMapper _mapper;
        public GetRequestTypeListHandler(IRequestTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<RequestTypeListDTO>>> Handle(GetRequestTypeListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<RequestTypeListDTO>>();

            var RequestTypes = await _repository.List();
            var mappedData = _mapper.Map<List<RequestTypeListDTO>>(RequestTypes);
            return operation.Succedded(mappedData);
        }
    }
}
