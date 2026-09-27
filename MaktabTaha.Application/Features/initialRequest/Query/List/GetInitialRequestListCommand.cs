using MaktabTaha.Application.Helpers;
using MediatR;
using MaktabTaha.Application.DTO_s.initialRequests.List;

namespace MaktabTaha.Application.Features.initialRequest.Query.List
{
    public class GetInitialRequestListCommand : IRequest<OperationResult<List<InitialRequestListDTO>>>
    {

    }
}
