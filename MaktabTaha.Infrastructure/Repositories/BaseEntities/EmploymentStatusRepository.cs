
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class EmploymentStatusRepository : GenericRepository<int, EmploymentStatus>, IEmploymentStatusRepository
{
    private readonly ApplicationDbContext _context;
    public EmploymentStatusRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
