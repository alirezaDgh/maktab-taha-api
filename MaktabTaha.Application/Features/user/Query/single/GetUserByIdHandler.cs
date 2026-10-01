using AutoMapper;
using MaktabTaha.Application.DTO_s.users.single;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;

namespace MaktabTaha.Application.Features.user.Query.single
{
    class GetUserByIdHandler : IRequestHandler<GetUserByIdCommand, OperationResult<SingleUserDTO>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public GetUserByIdHandler(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<OperationResult<SingleUserDTO>> Handle(GetUserByIdCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<SingleUserDTO>();
            var user = await _repository.GetBy(request.Id);

            if(user == null)
            {
                return operation.Failure("کاربر یافت نشد");
            }

            var result = _mapper.Map<SingleUserDTO>(user);
            return operation.Succedded(result);
        }
    }
}
