using fainting.Infrastructure.Entities;

namespace fainting.Infrastucture.Reposities
{
    public interface ILoginRepo
    {
        Task<User?> GetUserByEmail(string email);
    }
}
