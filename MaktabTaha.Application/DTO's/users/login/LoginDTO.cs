using MaktabTaha.Application.DTO_s.users.single;

namespace MaktabTaha.Application.DTO_s.users.login
{
    public class LoginDTO : SingleUserDTO
    {
        public string Token { get; set; }
    }
}
