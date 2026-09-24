using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.initialRequest.Command.Delete
{
    public class DeteteInitialRequestHandler : IRequestHandler<DeleteInitialRequestCommand, OperationResult<bool>>
    {
        private readonly IInitialRequestRepository _repository;

        public DeteteInitialRequestHandler(IInitialRequestRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<bool>> Handle(DeleteInitialRequestCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<bool>();

            var initialRequest = await _repository.GetBy(request.RequestNumber);
            if (initialRequest == null) return operation.Failure("درخواست اولیه وجود ندارد.");

            await _repository.Delete(initialRequest);
            return operation.Succedded(true);
        }
    }
}
