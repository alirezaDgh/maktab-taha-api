using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.physicalStatus.Query.List
{
    public class GetPhysicalStatusListCommand : IRequest<OperationResult<List<PhysicalStatus>>>
    {
    }
}
