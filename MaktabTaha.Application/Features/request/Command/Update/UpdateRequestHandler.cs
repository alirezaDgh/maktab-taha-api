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

namespace MaktabTaha.Application.Features.request.Command.Update
{
    public class UpdateRequestHandler : IRequestHandler<UpdateRequestCommand, OperationResult<Request>>
    {
        private readonly IRequestRepository _repository;
        private readonly IMapper _mapper;

        public UpdateRequestHandler(IRequestRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<Request>> Handle(UpdateRequestCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<Request>();

            var initialRequest = await _repository.FirstOrDefault(x => x.Id == request.Id);
            if (initialRequest == null) return operation.Failure("درخواست اولیه موجود نمیباشد");
            _mapper.Map(request, initialRequest);
            await _repository.Update(initialRequest);
            return operation.Succedded(initialRequest);
        }
    }
}
