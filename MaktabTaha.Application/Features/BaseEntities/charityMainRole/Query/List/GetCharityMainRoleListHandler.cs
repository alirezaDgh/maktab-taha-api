using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;

namespace MaktabTaha.Application.Features.BaseEntities.charityMainRole.Query.List
{
    public class GetCharityMainRoleListHandler : IRequestHandler<GetCharityMainRoleListCommand, OperationResult<List<CharityMainRole>>>
    {
        private readonly ICharityMainRoleRepository _repository;
        public GetCharityMainRoleListHandler(ICharityMainRoleRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<CharityMainRole>>> Handle(GetCharityMainRoleListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<CharityMainRole>>();

            var CharityMainRoles = await _repository.List();

            return operation.Succedded(CharityMainRoles);
        }
    }
}
