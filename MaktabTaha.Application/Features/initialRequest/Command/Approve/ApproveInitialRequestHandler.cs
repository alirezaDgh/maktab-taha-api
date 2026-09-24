using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.initialRequest.Command.Approve
{
    public class ApproveInitialRequestHandler : IRequestHandler<ApproveInitialRequestCommand, OperationResult<InitialRequest>>
    {
        private readonly IInitialRequestRepository _repository;
        private readonly IMapper _mapper;

        public ApproveInitialRequestHandler(IInitialRequestRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<InitialRequest>> Handle(ApproveInitialRequestCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<InitialRequest>();

            var initRequest = await _repository.SingleOrDefault(x => x.RequestNumber == request.RequestNumber);
            if (initRequest == null) return operation.Failure("درخواست اولیه یافت نشد");

            var mappedData = _mapper.Map(request, initRequest);
            await _repository.SaveChanges();

            return operation.Succedded(mappedData);
        }
    }
}
