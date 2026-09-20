using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Common;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.user.Command.Create
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, OperationResult<User>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        private readonly IPasswordHasher _passwordHasher;

        public CreateUserHandler(IUserRepository repository, IMapper mapper, IPasswordHasher passwordHasher)
        {
            _repository = repository;
            _mapper = mapper;
            _passwordHasher = passwordHasher;
        }

        async Task<OperationResult<User>> IRequestHandler<CreateUserCommand, OperationResult<User>>.Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<User>();

            var isHasUser = await _repository.Exists(x => x.UserName == request.UserName);
            if(isHasUser)
            {
                return operation.Failure("نام کاربری قبلا در سیستم ثبت شده است");
            }

            var password = _passwordHasher.Hash(request.Password);
            var user = _mapper.Map<User>(request);
            user.PasswordHash = password;
            user.LastEntry = DateTime.Now;

            await _repository.Create(user);
            return operation.Succedded(user);
            
        }
    }
}
