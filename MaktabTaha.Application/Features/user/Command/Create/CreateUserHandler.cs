using AutoMapper;
using MaktabTaha.Application.DTO_s.users.create;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Common;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.user.Command.Create
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, OperationResult<CreateUserDTO>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IRoleRepository _roleRepository;



        public CreateUserHandler(IUserRepository repository, IMapper mapper, IPasswordHasher passwordHasher, IRoleRepository roleRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _passwordHasher = passwordHasher;
            _roleRepository = roleRepository;
        }

        async Task<OperationResult<CreateUserDTO>> IRequestHandler<CreateUserCommand, OperationResult<CreateUserDTO>>.Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<CreateUserDTO>();

            var isHasUser = await _repository.Exists(x => x.UserName == request.UserName);
            if(isHasUser)
            {
                return operation.Failure("نام کاربری قبلا در سیستم ثبت شده است");
            }

            var role = await _roleRepository.GetBy(request.RoleId);
            if (role == null) return operation.Failure("نقش انتخاب شده وجود ندارد");
            


            var password = _passwordHasher.Hash(request.Password);
            var user = _mapper.Map<User>(request);
            user.PasswordHash = password;
            user.LastEntry = DateTime.Now;
            user.RoleId = role.Id;


            var response = new CreateUserDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Mobile = user.Mobile,
            };
            await _repository.Create(user);
            return operation.Succedded(response);
            
        }
    }
}
