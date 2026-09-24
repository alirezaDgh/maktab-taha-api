using MaktabTaha.Domain.Common;

namespace MaktabTaha.Domain.Entites
{
    public class Permission : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Key { get; set; }
        public string? Path { get; set; }
        public string? Icon { get; set; }
        public int? ParentId { get; set; }
        public int SortOrder { get; set; }
        public Permission? Parent { get; set; }
        public ICollection<Permission> Children { get; set; } = new List<Permission>();
        public ICollection<UserPermission> UserPermissions { get; set; } = new List<UserPermission>();


    }
}
