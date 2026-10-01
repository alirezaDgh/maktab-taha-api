using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.skill.Query.List
{
    public class GetSkillListCommand : IRequest<OperationResult<List<Skill>>>
    {
    }
}
