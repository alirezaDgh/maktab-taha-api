using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.CaseType.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.CaseType
{
    public class GetCaseTypeListHandler : IRequestHandler<GetCaseTypeListCommand, OperationResult<List<CaseTypeListDTO>>>
    {
        private readonly ICaseTypeRepository _repository;
        private readonly IMapper _mapper;
        public GetCaseTypeListHandler(ICaseTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<CaseTypeListDTO>>> Handle(GetCaseTypeListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<CaseTypeListDTO>>();

            var CaseTypes = await _repository.List();
            var mappedData = _mapper.Map<List<CaseTypeListDTO>>(CaseTypes);
            return operation.Succedded(mappedData);
        }
    }
}
