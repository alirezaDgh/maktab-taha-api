using AutoMapper;
using MaktabTaha.Application.Features.BaseEntities.job.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.job.Query.List
{
    public class GetJobListHandler : IRequestHandler<GetJobListCommand, OperationResult<List<Job>>>
    {
        private readonly IJobRepository _repository;
        public GetJobListHandler(IJobRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<Job>>> Handle(GetJobListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<Job>>();

            var Jobs = await _repository.List();

            return operation.Succedded(Jobs);
        }
    }
}
