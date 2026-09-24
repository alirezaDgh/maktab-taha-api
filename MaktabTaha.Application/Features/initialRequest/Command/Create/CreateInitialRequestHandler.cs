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

namespace MaktabTaha.Application.Features.initialRequest.Command.Create
{
    public class CreateInitialRequestHandler : IRequestHandler<CreateInitialRequestCommand, OperationResult<InitialRequest>>
    {
        private readonly IInitialRequestRepository _repository;
        private readonly IMapper _mapper;

        public CreateInitialRequestHandler(IInitialRequestRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<InitialRequest>> Handle(CreateInitialRequestCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<InitialRequest>();

            var mappedData = _mapper.Map<InitialRequest>(request);
            await _repository.Create(mappedData);
            return operation.Succedded(mappedData); 
        }
    }
}
