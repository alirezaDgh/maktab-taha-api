using MaktabTaha.Domain.Common;

namespace MaktabTaha.Domain.Entites
{
    public class Role : BaseEntity<int>
    {
        public string Title { get; set; }
        public bool IsSystemAdmin { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();

    }
}
