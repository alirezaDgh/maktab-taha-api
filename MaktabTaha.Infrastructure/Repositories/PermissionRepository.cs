using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;

namespace MaktabTaha.Infrastructure.Repositories
{
    public class PermissionRepository : GenericRepository<int, Permission>, IPermissionRepository
    {
        private readonly ApplicationDbContext _context;
        public PermissionRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;

        }
    }
}
