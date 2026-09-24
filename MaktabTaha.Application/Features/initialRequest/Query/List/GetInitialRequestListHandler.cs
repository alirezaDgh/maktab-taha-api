using AutoMapper;
using MaktabTaha.Application.DTOs.initialRequests.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.initialRequest.Query.List
{
    public class GetInitialRequestListHandler : IRequestHandler<GetInitialRequestListCommand, OperationResult<List<InitialRequestListDTO>>>
    {
        private readonly IInitialRequestRepository _repository;
        private readonly IMapper _mapper;

        public GetInitialRequestListHandler(IInitialRequestRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<InitialRequestListDTO>>> Handle(GetInitialRequestListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<InitialRequestListDTO>>();

            var initialRequests = await _repository.List();
            var mappedData = _mapper.Map<List<InitialRequestListDTO>>(initialRequests);
            return operation.Succedded(mappedData);
        }
    }
}
