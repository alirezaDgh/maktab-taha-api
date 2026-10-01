using AutoMapper;
using MaktabTaha.Application.Features.BaseEntities.skill.Query.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.skill.Query.List
{
    public class GetSkillListHandler : IRequestHandler<GetSkillListCommand, OperationResult<List<Skill>>>
    {
        private readonly ISkillRepository _repository;
        public GetSkillListHandler(ISkillRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<Skill>>> Handle(GetSkillListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<Skill>>();

            var Skills = await _repository.List();

            return operation.Succedded(Skills);
        }
    }
}
