using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.request.Command.Delete
{
    public class DeteteRequestHandler : IRequestHandler<DeleteRequestCommand, OperationResult<bool>>
    {
        private readonly IRequestRepository _repository;

        public DeteteRequestHandler(IRequestRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<bool>> Handle(DeleteRequestCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<bool>();

            var initialRequest = await _repository.GetBy(request.Id);
            if (initialRequest == null) return operation.Failure("درخواست اولیه وجود ندارد.");

            await _repository.Delete(initialRequest);
            return operation.Succedded(true);
        }
    }
}
