using MaktabTaha.Application.DTOs.BaseEntities.City.List;
using MaktabTaha.Domain.Entites.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Interfaces.Repositories.BaseEntities
{
    public interface ICityRepository : IGenericRepository<int, City>
    {
        Task<List<City>> GetCityListOfProvince(int provinceId);
    }
}
