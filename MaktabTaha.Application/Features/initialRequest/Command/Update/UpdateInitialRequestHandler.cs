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

namespace MaktabTaha.Application.Features.initialRequest.Command.Update
{
    public class UpdateInitialRequestHandler : IRequestHandler<UpdateInitialRequestCommand, OperationResult<InitialRequest>>
    {
        private readonly IInitialRequestRepository _repository;
        private readonly IMapper _mapper;

        public UpdateInitialRequestHandler(IInitialRequestRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<InitialRequest>> Handle(UpdateInitialRequestCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<InitialRequest>();

            var initialRequest = await _repository.FirstOrDefault(x => x.RequestNumber == request.RequestNumber);
            if (initialRequest == null) return operation.Failure("درخواست اولیه موجود نمیباشد");
            _mapper.Map(request, initialRequest);
            await _repository.Update(initialRequest);
            return operation.Succedded(initialRequest);
        }
    }
}
