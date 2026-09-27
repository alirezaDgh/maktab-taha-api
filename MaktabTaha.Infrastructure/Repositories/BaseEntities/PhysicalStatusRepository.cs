
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class PhysicalStatusRepository : GenericRepository<int, PhysicalStatus>, IPhysicalStatusRepository
{
    private readonly ApplicationDbContext _context;
    public PhysicalStatusRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
