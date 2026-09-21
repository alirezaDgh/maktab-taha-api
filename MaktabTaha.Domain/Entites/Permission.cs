using MaktabTaha.Domain.Common;

namespace MaktabTaha.Domain.Entites
{
    public class Permission : BaseEntity<int>
    {
        public string Title { get; set; }
        public ICollection<UserPermission> UserPermissions { get; set; } = new List<UserPermission>();

    }
}
