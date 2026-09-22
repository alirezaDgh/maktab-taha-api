using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Common;
using MediatR;

namespace MaktabTaha.Application.Features.user.Command.Login
{
    public class LoginUserHandler : IRequestHandler<LoginUserCommand, OperationResult<string>>
    {
        private readonly IUserRepository _repository;
        private readonly IPasswordHasher _hasher;
        private readonly ITokenServices _tokenService;
        private readonly IMapper _mapper;

        public LoginUserHandler(IUserRepository repository, IPasswordHasher hasher, ITokenServices tokenService, IMapper mapper)
        {
            _repository = repository;
            _hasher = hasher;
            _tokenService = tokenService;
            _mapper = mapper;
        }

        public async Task<OperationResult<string>> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<string>();

            var user = await _repository.SingleOrDefault(x => x.UserName == request.UserName);

            if (user is null || string.IsNullOrWhiteSpace(request.Password))
                return operation.Failure("نام کاربری یا رمز عبور اشتباه است");

            var check = _hasher.Check(user.PasswordHash, request.Password);

            if (!check.Verified)
                return operation.Failure("نام کاربری یا رمز عبور اشتباه است");

            if (check.NeedsUpgrade)
                user.PasswordHash = _hasher.Hash(request.Password);

            user.LastEntry = DateTime.UtcNow;
            await _repository.SaveChanges();

            var account = _mapper.Map<AuthViewModel>(user);

            var token = _tokenService.GenerateToken(account);
            return operation.Succedded(token);
        }
    }
}
