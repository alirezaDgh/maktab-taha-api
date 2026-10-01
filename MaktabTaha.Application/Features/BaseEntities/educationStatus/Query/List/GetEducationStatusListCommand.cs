using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.educationStatus.Query.List
{
    public class GetEducationStatusListCommand : IRequest<OperationResult<List<EducationStatus>>>
    {
    }
}
