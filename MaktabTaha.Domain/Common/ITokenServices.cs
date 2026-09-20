namespace MaktabTaha.Domain.Common
{
    public interface ITokenServices
    {
        string GenerateToken(AuthViewModel account);
    }
}
