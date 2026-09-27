
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class CharityMainRoleRepository : GenericRepository<int, CharityMainRole>, ICharityMainRoleRepository
{
    private readonly ApplicationDbContext _context;
    public CharityMainRoleRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
