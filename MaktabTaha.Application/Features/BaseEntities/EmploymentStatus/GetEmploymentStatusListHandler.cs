using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.EmploymentStatus.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.EmploymentStatus
{
    public class GetEmploymentStatusListHandler : IRequestHandler<GetEmploymentStatusListCommand, OperationResult<List<EmploymentStatusListDTO>>>
    {
        private readonly IEmploymentStatusRepository _repository;
        private readonly IMapper _mapper;
        public GetEmploymentStatusListHandler(IEmploymentStatusRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<EmploymentStatusListDTO>>> Handle(GetEmploymentStatusListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<EmploymentStatusListDTO>>();

            var EmploymentStatuss = await _repository.List();
            var mappedData = _mapper.Map<List<EmploymentStatusListDTO>>(EmploymentStatuss);
            return operation.Succedded(mappedData);
        }
    }
}
