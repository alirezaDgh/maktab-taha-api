using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.Relation.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.Relation
{
    public class GetRelationListHandler : IRequestHandler<GetRelationListCommand, OperationResult<List<RelationListDTO>>>
    {
        private readonly IRelationRepository _repository;
        private readonly IMapper _mapper;
        public GetRelationListHandler(IRelationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<RelationListDTO>>> Handle(GetRelationListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<RelationListDTO>>();

            var Relations = await _repository.List();
            var mappedData = _mapper.Map<List<RelationListDTO>>(Relations);
            return operation.Succedded(mappedData);
        }
    }
}
