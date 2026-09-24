using AutoMapper;
using MaktabTaha.Application.DTOs.initialRequests.Single;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.initialRequest.Query.Single
{
    public class GetInitialRequestByIdHandler : IRequestHandler<GetInitialRequestByIdCommand, OperationResult<GetInitialRequestDTO>>
    {
        private readonly IInitialRequestRepository _repository;
        private readonly IMapper _mapper;

        public GetInitialRequestByIdHandler(IInitialRequestRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<GetInitialRequestDTO>> Handle(GetInitialRequestByIdCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<GetInitialRequestDTO>();

            var initialRequest = await _repository.GetBy(request.RequestNumber);
            if (initialRequest == null) return operation.Failure("درخواست اولیه یافت نشد");
            var mappedData = _mapper.Map<GetInitialRequestDTO>(initialRequest);
            return operation.Succedded(mappedData);
        }
    }
}
