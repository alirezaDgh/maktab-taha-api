
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class RequestTypeRepository : GenericRepository<int, RequestType>, IRequestTypeRepository
{
    private readonly ApplicationDbContext _context;
    public RequestTypeRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
