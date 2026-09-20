using AutoMapper;
using MaktabTaha.Application.DTOs.users.update;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.user.Command.update
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, OperationResult<User>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UpdateUserHandler(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<OperationResult<User>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<User>();

            var user = await _repository.FirstOrDefault(x => x.Id == request.Id);
            if (user == null) return operation.Failure("کاربر یافت نشد");

            _mapper.Map(request, user);

            await _repository.Update(user);

            return operation.Succedded(user);
        }
    }
}
