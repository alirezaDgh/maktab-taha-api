
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MaktabTaha.Domain.Entites.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories.BaseEntities;

public class BankRepository : GenericRepository<int, Bank>, IBankRepository
{
    private readonly ApplicationDbContext _context;
    public BankRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
