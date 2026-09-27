using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.UnemploymentReason.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.UnemploymentReason
{
    public class GetUnemploymentReasonListHandler : IRequestHandler<GetUnemploymentReasonListCommand, OperationResult<List<UnemploymentReasonListDTO>>>
    {
        private readonly IUnemploymentReasonRepository _repository;
        private readonly IMapper _mapper;
        public GetUnemploymentReasonListHandler(IUnemploymentReasonRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<UnemploymentReasonListDTO>>> Handle(GetUnemploymentReasonListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<UnemploymentReasonListDTO>>();

            var UnemploymentReasons = await _repository.List();
            var mappedData = _mapper.Map<List<UnemploymentReasonListDTO>>(UnemploymentReasons);
            return operation.Succedded(mappedData);
        }
    }
}
