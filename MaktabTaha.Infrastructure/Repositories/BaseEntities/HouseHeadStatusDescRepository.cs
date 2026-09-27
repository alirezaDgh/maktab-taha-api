
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class HouseHeadStatusDescRepository : GenericRepository<int, HouseHeadStatusDesc>, IHouseHeadStatusDescRepository
{
    private readonly ApplicationDbContext _context;
    public HouseHeadStatusDescRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
