using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.Skill.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.Skill
{
    public class GetSkillListHandler : IRequestHandler<GetSkillListCommand, OperationResult<List<SkillListDTO>>>
    {
        private readonly ISkillRepository _repository;
        private readonly IMapper _mapper;
        public GetSkillListHandler(ISkillRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<SkillListDTO>>> Handle(GetSkillListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<SkillListDTO>>();

            var Skills = await _repository.List();
            var mappedData = _mapper.Map<List<SkillListDTO>>(Skills);
            return operation.Succedded(mappedData);
        }
    }
}
