using fainting.Infrastructure.Context;
using fainting.Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace fainting.Infrastucture.Reposities
{
    public class LoginRepo(FaintingContext faintingContext) : ControllerBase, ILoginRepo
    {
        public async Task<User?> GetUserByEmail(string email)
        {
            return await faintingContext.User.SingleOrDefaultAsync(x => x.Email == email);
        }
    }
}
