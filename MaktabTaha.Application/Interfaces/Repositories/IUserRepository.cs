using MaktabTaha.Application.DTO_s.users.list;
using MaktabTaha.Application.DTO_s.users.single;
using MaktabTaha.Domain.Entites;

namespace MaktabTaha.Application.Interfaces.Repositories
{
    public interface IUserRepository : IGenericRepository<int, User>
    {
        Task<List<UserListDTO>> GetAllList();
        Task<SingleUserDTO> GetUser(int id);
        Task<User> GetUserForLogin(string userName);
    }
}
