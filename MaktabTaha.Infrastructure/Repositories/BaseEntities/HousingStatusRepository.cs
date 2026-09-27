
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class HousingStatusRepository : GenericRepository<int, HousingStatus>, IHousingStatusRepository
{
    private readonly ApplicationDbContext _context;
    public HousingStatusRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
