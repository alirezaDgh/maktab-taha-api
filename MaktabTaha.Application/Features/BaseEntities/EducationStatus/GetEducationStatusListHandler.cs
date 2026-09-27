using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.EducationStatus.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.EducationStatus
{
    public class GetEducationStatusListHandler : IRequestHandler<GetEducationStatusListCommand, OperationResult<List<EducationStatusListDTO>>>
    {
        private readonly IEducationStatusRepository _repository;
        private readonly IMapper _mapper;
        public GetEducationStatusListHandler(IEducationStatusRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<EducationStatusListDTO>>> Handle(GetEducationStatusListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<EducationStatusListDTO>>();

            var EducationStatuss = await _repository.List();
            var mappedData = _mapper.Map<List<EducationStatusListDTO>>(EducationStatuss);
            return operation.Succedded(mappedData);
        }
    }
}
