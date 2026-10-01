using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.privatenessStatus.Query.List
{
    public class GetPrivatenessStatusListCommand : IRequest<OperationResult<List<PrivatenessStatus>>>
    {

    }
}
