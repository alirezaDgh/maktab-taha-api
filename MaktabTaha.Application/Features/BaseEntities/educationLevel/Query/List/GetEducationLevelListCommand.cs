using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.educationLevel.Query.List
{
    public class GetEducationLevelListCommand : IRequest<OperationResult<List<EducationLevel>>>
    {
    }
}
