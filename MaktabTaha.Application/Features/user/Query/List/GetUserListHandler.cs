using AutoMapper;
using MaktabTaha.Application.DTOs.users.list;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;

namespace MaktabTaha.Application.Features.user.Query.List
{
    class GetUserListHandler : IRequestHandler<GetUserListCommand, OperationResult<List<UserListDTO>>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public GetUserListHandler(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<UserListDTO>>> Handle(GetUserListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<UserListDTO>>();

            var users = await _repository.List();
            var result = _mapper.Map<List<UserListDTO>>(users);

            return operation.Succedded(result);
        }
    }
}
