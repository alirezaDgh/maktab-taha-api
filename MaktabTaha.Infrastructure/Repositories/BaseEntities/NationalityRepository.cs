
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class NationalityRepository : GenericRepository<int, Nationality>, INationalityRepository
{
    private readonly ApplicationDbContext _context;
    public NationalityRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
