using MaktabTaha.Domain.Entites;

namespace MaktabTaha.Application.DTOs.users.create
{
    public class CreateUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Mobile { get; set; }
        public ICollection<Permission> Permissions { get; set; }


    }
}
