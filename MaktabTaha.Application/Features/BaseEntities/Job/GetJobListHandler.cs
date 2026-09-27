using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.Job.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.Job
{
    public class GetJobListHandler : IRequestHandler<GetJobListCommand, OperationResult<List<JobListDTO>>>
    {
        private readonly IJobRepository _repository;
        private readonly IMapper _mapper;
        public GetJobListHandler(IJobRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<JobListDTO>>> Handle(GetJobListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<JobListDTO>>();

            var Jobs = await _repository.List();
            var mappedData = _mapper.Map<List<JobListDTO>>(Jobs);
            return operation.Succedded(mappedData);
        }
    }
}
