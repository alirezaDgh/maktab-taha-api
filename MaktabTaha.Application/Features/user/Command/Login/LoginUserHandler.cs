using MaktabTaha.Application.DTO_s.users.list;
using MaktabTaha.Application.DTO_s.users.login;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Common;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.user.Command.Login
{
    public class LoginUserHandler
        : IRequestHandler<LoginUserCommand, OperationResult<LoginDTO>>
    {
        private readonly IUserRepository _repository;
        private readonly IPasswordHasher _hasher;
        private readonly ITokenServices _tokenService;

        public LoginUserHandler(
            IUserRepository repository,
            IPasswordHasher hasher,
            ITokenServices tokenService)
        {
            _repository = repository;
            _hasher = hasher;
            _tokenService = tokenService;
        }

        public async Task<OperationResult<LoginDTO>> Handle(
            LoginUserCommand request,
            CancellationToken cancellationToken)
        {
            var operation = new OperationResult<LoginDTO>();

            if (string.IsNullOrWhiteSpace(request.UserName) ||
                string.IsNullOrWhiteSpace(request.Password))
            {
                return operation.Failure(
                    "نام کاربری یا رمز عبور اشتباه است"
                );
            }

            // مهم:
            // User + Role + RolePermissions + Permission
            var user = await _repository.GetUserForLogin(
                request.UserName
            );

            if (user is null)
            {
                return operation.Failure(
                    "نام کاربری یا رمز عبور اشتباه است"
                );
            }

            var check = _hasher.Check(
                user.PasswordHash,
                request.Password
            );

            if (!check.Verified)
            {
                return operation.Failure(
                    "نام کاربری یا رمز عبور اشتباه است"
                );
            }

            if (check.NeedsUpgrade)
            {
                user.PasswordHash = _hasher.Hash(
                    request.Password
                );
            }

            user.LastEntry = DateTime.UtcNow;

            await _repository.SaveChanges();

            var account = new AuthViewModel
            {
                Id = user.Id,
                UserName = user.UserName
            };

            var token = _tokenService.GenerateToken(account);

            var result = new LoginDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Mobile = user.Mobile,
                Token = token,

                Role = new UserRoleDTO
                {
                    RoleId = user.RoleId,
                    RoleTitle = user.Role?.Title,

                    Permissions = BuildPermissionTree(
                        user.Role?.RolePermissions?
                            .Where(x => x.Permission != null)
                            .Select(x => x.Permission!)
                            .ToList()
                        ?? new List<Permission>()
                    )
                }
            };

            return operation.Succedded(result);
        }

        private static List<UserPermissionDTO> BuildPermissionTree(
            List<Permission> permissions)
        {
            var permissionDtos = permissions
                .Select(permission => new UserPermissionDTO
                {
                    Id = permission.Id,
                    Title = permission.Title,
                    Key = permission.Key,
                    Path = permission.Path,
                    Icon = permission.Icon,
                    ParentId = permission.ParentId,
                    SortOrder = permission.SortOrder
                })
                .ToList();

            var lookup = permissionDtos.ToDictionary(
                x => x.Id
            );

            var roots = new List<UserPermissionDTO>();

            foreach (var permission in permissionDtos)
            {
                if (permission.ParentId == null)
                {
                    roots.Add(permission);
                    continue;
                }

                if (lookup.TryGetValue(
                    permission.ParentId.Value,
                    out var parent))
                {
                    parent.Children.Add(permission);
                }
            }

            SortChildren(roots);

            return roots;
        }

        private static void SortChildren(
            List<UserPermissionDTO> permissions)
        {
            permissions.Sort(
                (a, b) => a.SortOrder.CompareTo(b.SortOrder)
            );

            foreach (var permission in permissions)
            {
                SortChildren(permission.Children);
            }
        }
    }
}