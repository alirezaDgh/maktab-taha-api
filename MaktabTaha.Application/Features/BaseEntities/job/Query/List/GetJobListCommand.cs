using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.job.Query.List
{
    public class GetJobListCommand : IRequest<OperationResult<List<Job>>>
    {
    }
}
