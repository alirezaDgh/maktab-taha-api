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

namespace MaktabTaha.Application.Features.request.Command.Create
{
    public class CreateRequestHandler : IRequestHandler<CreateRequestCommand, OperationResult<Request>>
    {
        private readonly IRequestRepository _repository;
        private readonly IMapper _mapper;

        public CreateRequestHandler(IRequestRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<Request>> Handle(CreateRequestCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<Request>();

            var mappedData = _mapper.Map<Request>(request);
            await _repository.Create(mappedData);
            return operation.Succedded(mappedData); 
        }
    }
}
