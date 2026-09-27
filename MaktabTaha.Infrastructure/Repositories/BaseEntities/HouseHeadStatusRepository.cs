
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class HouseHeadStatusRepository : GenericRepository<int, HouseHeadStatus>, IHouseHeadStatusRepository
{
    private readonly ApplicationDbContext _context;
    public HouseHeadStatusRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
