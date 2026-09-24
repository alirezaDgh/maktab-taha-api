using MaktabTaha.Domain.Common;

namespace MaktabTaha.Domain.Entites
{
    public class User : BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string? PasswordHash { get; set; }
        public string Mobile { get; set; }
        public DateTime? LastEntry { get; set; } = DateTime.Now;
        //public int RoleId { get; set; }
        //public Role Role { get; set; }

        public ICollection<UserPermission> UserPermissions { get; set; } = new List<UserPermission>();
    }
}
