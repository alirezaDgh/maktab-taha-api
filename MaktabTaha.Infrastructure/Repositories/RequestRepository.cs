using MaktabTaha.Application.DTO_s.Requests.List;
using MaktabTaha.Application.DTO_s.Requests.Search;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Infrastructure.Repositories
{
    public class RequestRepository : GenericRepository<int, Request>, IRequestRepository
    {
        private readonly ApplicationDbContext _context;
        public RequestRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<RequestListDTO>> SearchRequest(SearchRequestListDTO entity)
        {
            var query = _context.Request.AsQueryable();


            if (entity.RequestId.HasValue)
            {
                query = query.Where(x => x.Id == entity.RequestId);
            }

            if (!string.IsNullOrWhiteSpace(entity.ClientFirstName))
            {
                query = query.Where(x => x.ClientFirstName.Contains(entity.ClientFirstName));
            }

            if (!string.IsNullOrWhiteSpace (entity.ClientLastName))
            {
                query = query.Where(x => x.ClientLastName.Contains(entity.ClientLastName));
            }

            if (entity.RequestTypeId.HasValue)
            {
                query = query.Where(x => x.Id == entity.RequestId.Value);
            }

            if (entity.RequestStatusId.HasValue)
            {
                query = query.Where(x => x.RequestStatusId == entity.RequestStatusId.Value);
            }

            if (entity.FromApproveDate.HasValue)
            {
                query = query.Where(x => x.RequestDate >=  entity.FromApproveDate.Value);
            }

            if (entity.ToApproveDate.HasValue)
            {
                query = query.Where(x => x.RequestDate <= entity.ToApproveDate.Value);
            }

            return await query.Select(x => new RequestListDTO
            {
                Id = x.Id,
                RequestDate = x.RequestDate,
                ClientFirstName = x.ClientFirstName,
                ClientLastName = x.ClientLastName,
                RequestTypeId = x.RequestTypeId,
                RequestStatusId = x.RequestStatusId,
            }).ToListAsync();
        }
    }
}
