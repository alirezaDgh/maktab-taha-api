using MaktabTaha.Application.DTO_s.users.list;
using MaktabTaha.Domain.Entites;

namespace MaktabTaha.Application.Interfaces.Repositories
{
    public interface IUserRepository : IGenericRepository<int, User>
    {
        Task<List<UserListDTO>> GetAllList();
    }
}
