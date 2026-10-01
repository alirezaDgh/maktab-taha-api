using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.unemploymentReason.Query.List
{
    public class GetUnemploymentReasonListCommand : IRequest<OperationResult<List<UnemploymentReason>>>
    {
    }
}
