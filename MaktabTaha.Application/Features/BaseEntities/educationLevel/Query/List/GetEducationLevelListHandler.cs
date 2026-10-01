using AutoMapper;
using MaktabTaha.Application.Features.BaseEntities.educationLevel.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.educationLevel.Query.List
{
    public class GetEducationLevelListHandler : IRequestHandler<GetEducationLevelListCommand, OperationResult<List<EducationLevel>>>
    {
        private readonly IEducationLevelRepository _repository;
        public GetEducationLevelListHandler(IEducationLevelRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<EducationLevel>>> Handle(GetEducationLevelListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<EducationLevel>>();

            var EducationLevels = await _repository.List();

            return operation.Succedded(EducationLevels);
        }
    }
}
