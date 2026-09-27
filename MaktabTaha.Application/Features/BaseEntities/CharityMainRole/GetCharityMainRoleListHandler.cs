using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.CharityMainRole.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.CharityMainRole
{
    public class GetCharityMainRoleListHandler : IRequestHandler<GetCharityMainRoleListCommand, OperationResult<List<CharityMainRoleListDTO>>>
    {
        private readonly ICharityMainRoleRepository _repository;
        private readonly IMapper _mapper;
        public GetCharityMainRoleListHandler(ICharityMainRoleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<CharityMainRoleListDTO>>> Handle(GetCharityMainRoleListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<CharityMainRoleListDTO>>();

            var CharityMainRoles = await _repository.List();
            var mappedData = _mapper.Map<List<CharityMainRoleListDTO>>(CharityMainRoles);
            return operation.Succedded(mappedData);
        }
    }
}
