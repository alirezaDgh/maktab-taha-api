using AutoMapper;
using MaktabTaha.Application.Features.BaseEntities.requestType.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.requestType.Query.List
{
    public class GetRequestTypeListHandler : IRequestHandler<GetRequestTypeListCommand, OperationResult<List<RequestType>>>
    {
        private readonly IRequestTypeRepository _repository;
        public GetRequestTypeListHandler(IRequestTypeRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<RequestType>>> Handle(GetRequestTypeListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<RequestType>>();

            var RequestTypes = await _repository.List();

            return operation.Succedded(RequestTypes);
        }
    }
}
