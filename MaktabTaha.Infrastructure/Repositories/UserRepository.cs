using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;

namespace MaktabTaha.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<int, User>, IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
