using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.orphanStatus.Query.List
{
    public class GetOrphanStatusListCommand : IRequest<OperationResult<List<OrphanStatus>>>
    {
    }
}
