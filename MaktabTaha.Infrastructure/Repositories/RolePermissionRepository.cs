using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories
{
    public class RolePermissionRepository : GenericRepository<int, RolePermission>, IRolePermissionRepository
    {
        private readonly ApplicationDbContext _context;
        public RolePermissionRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;

        }
        public Task<List<RolePermission>> GetListWithoutIsDeleted()
        {
            return _context.RolePermission.ToListAsync();
        }
    }
}
