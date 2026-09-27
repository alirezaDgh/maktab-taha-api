using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.EducationLevel.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.EducationLevel
{
    public class GetEducationLevelListHandler : IRequestHandler<GetEducationLevelListCommand, OperationResult<List<EducationLevelListDTO>>>
    {
        private readonly IEducationLevelRepository _repository;
        private readonly IMapper _mapper;
        public GetEducationLevelListHandler(IEducationLevelRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<EducationLevelListDTO>>> Handle(GetEducationLevelListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<EducationLevelListDTO>>();

            var EducationLevels = await _repository.List();
            var mappedData = _mapper.Map<List<EducationLevelListDTO>>(EducationLevels);
            return operation.Succedded(mappedData);
        }
    }
}
