using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.educationStatus.Query.List
{
    public class GetEducationStatusListHandler : IRequestHandler<GetEducationStatusListCommand, OperationResult<List<EducationStatus>>>
    {
        private readonly IEducationStatusRepository _repository;
        public GetEducationStatusListHandler(IEducationStatusRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<EducationStatus>>> Handle(GetEducationStatusListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<EducationStatus>>();

            var EducationStatuss = await _repository.List();

            return operation.Succedded(EducationStatuss);
        }
    }
}
