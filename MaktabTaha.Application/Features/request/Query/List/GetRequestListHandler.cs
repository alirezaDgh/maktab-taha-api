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
        private readonly IMapper _mapper;

        public GetRequestListHandler(IRequestRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<RequestListDTO>>> Handle(GetRequestListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<RequestListDTO>>();

            var initialRequests = await _repository.ListWithoutIsDeleted();
            var mappedData = _mapper.Map<List<RequestListDTO>>(initialRequests);
            return operation.Succedded(mappedData);
        }
    }
}
