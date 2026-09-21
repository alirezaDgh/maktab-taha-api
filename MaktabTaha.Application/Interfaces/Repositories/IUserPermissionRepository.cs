using MaktabTaha.Domain.Entites;

namespace MaktabTaha.Application.Interfaces.Repositories
{
    public interface IUserPermissionRepository : IGenericRepository<int, UserPermission>
    {
        Task<List<UserPermission>> GetListWithoutIsDeleted();
    }
}
