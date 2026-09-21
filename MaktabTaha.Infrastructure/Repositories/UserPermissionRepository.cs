using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories
{
    public class UserPermissionRepository : GenericRepository<int, UserPermission>, IUserPermissionRepository
    {
        private readonly ApplicationDbContext _context;
        public UserPermissionRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;

        }
        public Task<List<UserPermission>> GetListWithoutIsDeleted()
        {
            return _context.UserPermissions.ToListAsync();
        }
    }
}
