
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class EducationLevelRepository : GenericRepository<int, EducationLevel>, IEducationLevelRepository
{
    private readonly ApplicationDbContext _context;
    public EducationLevelRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
