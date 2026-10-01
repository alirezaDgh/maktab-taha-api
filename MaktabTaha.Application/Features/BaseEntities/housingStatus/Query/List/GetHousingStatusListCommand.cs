using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.housingStatus.Query.List
{
    public class GetHousingStatusListCommand : IRequest<OperationResult<List<HousingStatus>>>
    {
    }
}
