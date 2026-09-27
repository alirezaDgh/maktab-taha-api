
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class SkillRepository : GenericRepository<int, Skill>, ISkillRepository
{
    private readonly ApplicationDbContext _context;
    public SkillRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
