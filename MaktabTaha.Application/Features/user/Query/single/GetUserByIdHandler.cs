using AutoMapper;
using MaktabTaha.Application.DTOs.users.single;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;

namespace MaktabTaha.Application.Features.user.Query.single
{
    class GetUserByIdHandler : IRequestHandler<GetUserByIdCommand, OperationResult<GetUserDTO>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public GetUserByIdHandler(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<OperationResult<GetUserDTO>> Handle(GetUserByIdCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<GetUserDTO>();
            var user = await _repository.GetBy(request.Id);

            if(user == null)
            {
                return operation.Failure("کاربر یافت نشد");
            }

            var result = _mapper.Map<GetUserDTO>(user);
            return operation.Succedded(result);
        }
    }
}
