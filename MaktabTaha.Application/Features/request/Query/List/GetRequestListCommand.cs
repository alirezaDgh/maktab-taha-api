using MaktabTaha.Application.Helpers;
using MediatR;
using MaktabTaha.Application.DTO_s.Requests.List;
using MaktabTaha.Application.DTO_s.Requests.Search;

namespace MaktabTaha.Application.Features.request.Query.List
{
    public class GetRequestListCommand : IRequest<OperationResult<List<RequestListDTO>>>
    {
        public SearchRequestListDTO Filters { get; set; }
    }
}
