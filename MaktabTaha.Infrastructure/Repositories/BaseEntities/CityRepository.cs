using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class CityRepository : GenericRepository<int, City>, ICityRepository
{
    private readonly ApplicationDbContext _context;
    public CityRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<City>> GetCityListOfProvince(int provinceId)
    {
        return await _context.City
            .Where(x => x.ProvinceId == provinceId).ToListAsync();
    }
}
