using MaktabTaha.Application.DTO_s.Requests.List;
using MaktabTaha.Application.DTO_s.Requests.Search;
using MaktabTaha.Domain.Entites;
using MaktabTaha.Domain.Entites.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Interfaces.Repositories
{
    public interface IRequestRepository : IGenericRepository<int, Request>
    {
        Task<List<RequestListDTO>> SearchRequest(SearchRequestListDTO entity);
    }
}
