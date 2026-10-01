using AutoMapper;
using MaktabTaha.Application.DTO_s.Requests.Single;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.request.Query.Single
{
    public class GetRequestByIdHandler : IRequestHandler<GetRequestByIdCommand, OperationResult<SingleRequestDTO>>
    {
        private readonly IRequestRepository _repository;
        private readonly IMapper _mapper;

        public GetRequestByIdHandler(IRequestRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<SingleRequestDTO>> Handle(GetRequestByIdCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<SingleRequestDTO>();

            var initialRequest = await _repository.GetBy(request.Id);
            if (initialRequest == null) return operation.Failure("درخواست اولیه یافت نشد");
            var mappedData = _mapper.Map<SingleRequestDTO>(initialRequest);
            return operation.Succedded(mappedData);
        }
    }
}
