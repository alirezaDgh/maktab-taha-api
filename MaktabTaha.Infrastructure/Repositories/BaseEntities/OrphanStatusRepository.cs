
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class OrphanStatusRepository : GenericRepository<int, OrphanStatus>, IOrphanStatusRepository
{
    private readonly ApplicationDbContext _context;
    public OrphanStatusRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
