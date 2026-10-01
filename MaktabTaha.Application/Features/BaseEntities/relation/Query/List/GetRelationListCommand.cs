using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.relation.Query.List
{
    public class GetRelationListCommand : IRequest<OperationResult<List<Relation>>>
    {
    }
}
