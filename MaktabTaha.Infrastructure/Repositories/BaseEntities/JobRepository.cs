
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class JobRepository : GenericRepository<int, Job>, IJobRepository
{
    private readonly ApplicationDbContext _context;
    public JobRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
