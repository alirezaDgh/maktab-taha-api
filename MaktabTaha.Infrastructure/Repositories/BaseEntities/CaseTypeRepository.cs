
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class CaseTypeRepository : GenericRepository<int, CaseType>, ICaseTypeRepository
{
    private readonly ApplicationDbContext _context;
    public CaseTypeRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
