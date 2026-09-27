
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class ProvinceRepository : GenericRepository<int, Province>, IProvinceRepository
{
    private readonly ApplicationDbContext _context;
    public ProvinceRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
