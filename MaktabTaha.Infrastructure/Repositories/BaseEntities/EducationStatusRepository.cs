
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class EducationStatusRepository : GenericRepository<int, EducationStatus>, IEducationStatusRepository
{
    private readonly ApplicationDbContext _context;
    public EducationStatusRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
