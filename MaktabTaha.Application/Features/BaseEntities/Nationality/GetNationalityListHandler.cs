using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.Nationality.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.Nationality
{
    public class GetNationalityListHandler : IRequestHandler<GetNationalityListCommand, OperationResult<List<NationalityListDTO>>>
    {
        private readonly INationalityRepository _repository;
        private readonly IMapper _mapper;
        public GetNationalityListHandler(INationalityRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<NationalityListDTO>>> Handle(GetNationalityListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<NationalityListDTO>>();

            var Nationalitys = await _repository.List();
            var mappedData = _mapper.Map<List<NationalityListDTO>>(Nationalitys);
            return operation.Succedded(mappedData);
        }
    }
}
