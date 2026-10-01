using MaktabTaha.Application.DTO_s.users.list;
using MaktabTaha.Application.DTO_s.users.single;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<int, User>, IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        private static void SortChildren(List<UserPermissionDTO> permissions)
        {
            permissions.Sort(
                (a, b) => a.SortOrder.CompareTo(b.SortOrder)
            );

            foreach (var permission in permissions)
            {
                SortChildren(permission.Children);
            }
        }

        private static List<UserPermissionDTO> BuildPermissionTree(List<Permission> permissions)
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

            var lookup = permissionDtos.ToDictionary(x => x.Id);

            var roots = new List<UserPermissionDTO>();

            foreach (var permission in permissionDtos)
            {
                if (permission.ParentId == null)
                {
                    roots.Add(permission);
                    continue;
                }

                if (lookup.TryGetValue(permission.ParentId.Value, out var parent))
                {
                    parent.Children.Add(permission);
                }
            }

            SortChildren(roots);

            return roots;
        }

        public async Task<List<UserListDTO>> GetAllList()
        {
            var users = await _context.User
                .AsNoTracking()
                .Include(x => x.Role)
                    .ThenInclude(x => x.RolePermissions)
                        .ThenInclude(x => x.Permission)
                .ToListAsync();

            return users.Select(user => new UserListDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Mobile = user.Mobile,
                LastEntry = user.LastEntry,

                IsActive = user.IsActive,

                Role = new UserRoleDTO
                {
                    RoleId = user.RoleId,
                    RoleTitle = user.Role.Title,

                    Permissions = BuildPermissionTree(
                        user.Role.RolePermissions
                            .Select(x => x.Permission)
                            .ToList()
                    )
                }
            }).ToList();
        }

        public async Task<SingleUserDTO?> GetUser(int id)
        {
            var user = await _context.User
                .AsNoTracking()
                .Include(x => x.Role)
                    .ThenInclude(x => x.RolePermissions)
                        .ThenInclude(x => x.Permission)
                .SingleOrDefaultAsync(x => x.Id == id);

            if (user == null)
                return null;

            return new SingleUserDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Mobile = user.Mobile,

                Role = new UserRoleDTO
                {
                    RoleId = user.RoleId,
                    RoleTitle = user.Role.Title,

                    Permissions = BuildPermissionTree(
                        user.Role.RolePermissions
                            .Select(x => x.Permission)
                            .ToList()
                    )
                }
            };
        }
        public async Task<User?> GetUserForLogin(
        string userName)
        {
            return await _context.User
                .Include(x => x.Role)
                    .ThenInclude(x => x.RolePermissions)
                        .ThenInclude(x => x.Permission)
                .SingleOrDefaultAsync(
                    x => x.UserName == userName
                );
        }

    }

}

