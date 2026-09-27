
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class GoodWorkTypeRepository : GenericRepository<int, GoodWorkType>, IGoodWorkTypeRepository
{
    private readonly ApplicationDbContext _context;
    public GoodWorkTypeRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
