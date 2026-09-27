using MaktabTaha.Application.DTOs.BaseEntities.Skill.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.Skill
{
    public class GetSkillListCommand : IRequest<OperationResult<List<SkillListDTO>>>
    {
    }
}
