using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Infrastructure.Repositories
{
    public class InitialRequestRepository : GenericRepository<int, InitialRequest>, IInitialRequestRepository
    {
        private readonly ApplicationDbContext _context;
        public InitialRequestRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
