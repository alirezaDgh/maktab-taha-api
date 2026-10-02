using AutoMapper;
using MaktabTaha.Application.DTO_s.Requests.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;

namespace MaktabTaha.Application.Features.request.Query.List
{
    public class GetRequestListHandler : IRequestHandler<GetRequestListCommand, OperationResult<List<RequestListDTO>>>
    {
        private readonly IRequestRepository _repository;

        public GetRequestListHandler(IRequestRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<RequestListDTO>>> Handle(GetRequestListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<RequestListDTO>>();

            var filterRequest = await _repository.SearchRequest(request.Filters);
            
            return operation.Succedded(filterRequest);
        }
    }
}
