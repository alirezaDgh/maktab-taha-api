using MaktabTaha.Application.Helpers;
using MediatR;
using MaktabTaha.Application.DTO_s.Requests.List;

namespace MaktabTaha.Application.Features.request.Query.List
{
    public class GetRequestListCommand : IRequest<OperationResult<List<RequestListDTO>>>
    {

    }
}
