using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.requestType.Query.List
{
    public class GetRequestTypeListCommand : IRequest<OperationResult<List<RequestType>>>
    {
    }
}
