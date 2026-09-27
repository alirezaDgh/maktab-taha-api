using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.PrivatenessStatus.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.PrivatenessStatus
{
    public class GetPrivatenessStatusListHandler : IRequestHandler<GetPrivatenessStatusListCommand, OperationResult<List<PrivatenessStatusListDTO>>>
    {
        private readonly IPrivatenessStatusRepository _repository;
        private readonly IMapper _mapper;
        public GetPrivatenessStatusListHandler(IPrivatenessStatusRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<PrivatenessStatusListDTO>>> Handle(GetPrivatenessStatusListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<PrivatenessStatusListDTO>>();

            var PrivatenessStatuss = await _repository.List();
            var mappedData = _mapper.Map<List<PrivatenessStatusListDTO>>(PrivatenessStatuss);
            return operation.Succedded(mappedData);
        }
    }
}
