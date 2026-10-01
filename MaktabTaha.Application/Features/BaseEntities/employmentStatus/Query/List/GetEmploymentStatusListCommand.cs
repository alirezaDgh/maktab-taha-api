using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.employmentStatus.Query.List
{
    public class GetEmploymentStatusListCommand : IRequest<OperationResult<List<EmploymentStatus>>>
    {
    }
}
