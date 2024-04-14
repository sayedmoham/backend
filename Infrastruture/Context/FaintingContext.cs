using fainting.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace fainting.Infrastructure.Context
{
    public class FaintingContext(DbContextOptions<FaintingContext> options) : DbContext(options)
    {
        #region DBSets
        public DbSet<User> User { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region User
            builder.Entity<User>().HasKey(x => x.UserId);
            #endregion
        }
    }
}
