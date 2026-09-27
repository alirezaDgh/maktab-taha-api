
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class PrivatenessStatusRepository : GenericRepository<int, PrivatenessStatus>, IPrivatenessStatusRepository
{
    private readonly ApplicationDbContext _context;
    public PrivatenessStatusRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
