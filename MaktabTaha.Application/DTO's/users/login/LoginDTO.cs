using MaktabTaha.Application.DTO_s.users.single;

namespace MaktabTaha.Application.DTO_s.users.login
{
    public class LoginDTO : GetUserDTO
    {
        public string Token { get; set; }
    }
}
