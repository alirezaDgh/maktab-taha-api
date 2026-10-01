using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.area.Query.List
{
    public class GetAreaListCommand : IRequest<OperationResult<List<Area>>>
    {
    }
}
