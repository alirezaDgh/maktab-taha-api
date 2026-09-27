using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.Religon.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.Religon
{
    public class GetReligonListHandler : IRequestHandler<GetReligonListCommand, OperationResult<List<ReligonListDTO>>>
    {
        private readonly IReligonRepository _repository;
        private readonly IMapper _mapper;
        public GetReligonListHandler(IReligonRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<ReligonListDTO>>> Handle(GetReligonListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<ReligonListDTO>>();

            var Religons = await _repository.List();
            var mappedData = _mapper.Map<List<ReligonListDTO>>(Religons);
            return operation.Succedded(mappedData);
        }
    }
}
