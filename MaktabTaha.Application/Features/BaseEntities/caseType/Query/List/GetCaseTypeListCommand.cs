using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.caseType.Query.List
{
    public class GetCaseTypeListCommand : IRequest<OperationResult<List<CaseType>>>
    {
    }
}
