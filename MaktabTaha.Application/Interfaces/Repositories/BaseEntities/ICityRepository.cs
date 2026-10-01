using MaktabTaha.Domain.Entites.BaseEntities;

namespace MaktabTaha.Application.Interfaces.Repositories.BaseEntities
{
    public interface ICityRepository : IGenericRepository<int, City>
    {
        Task<List<City>> GetCityListOfProvince(int provinceId);
    }
}
