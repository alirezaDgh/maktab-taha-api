using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.employmentStatus.Query.List
{
    public class GetEmploymentStatusListHandler : IRequestHandler<GetEmploymentStatusListCommand, OperationResult<List<EmploymentStatus>>>
    {
        private readonly IEmploymentStatusRepository _repository;
        public GetEmploymentStatusListHandler(IEmploymentStatusRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<EmploymentStatus>>> Handle(GetEmploymentStatusListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<EmploymentStatus>>();

            var EmploymentStatuss = await _repository.List();

            return operation.Succedded(EmploymentStatuss);
        }
    }
}
