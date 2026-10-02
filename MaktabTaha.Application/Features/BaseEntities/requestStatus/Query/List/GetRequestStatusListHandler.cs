using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.requestStatus.Query.List
{
    public class GetRequestStatusListHandler : IRequestHandler<GetRequestStatusListCommand, OperationResult<List<RequestStatus>>>
    {
        private readonly IRequestStatusRepository _repository;

        public GetRequestStatusListHandler(IRequestStatusRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<RequestStatus>>> Handle(GetRequestStatusListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<RequestStatus>>();

            var RequestStatuses = await _repository.List();

            return operation.Succedded(RequestStatuses);
        }
    }
}
