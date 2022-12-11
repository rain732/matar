using Matar.Data.EntityModels.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Matar.Data
{
    public class MatarDbContext : IdentityDbContext<User>
    {
        public MatarDbContext(DbContextOptions options) 
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        #region DbSetEntities
#pragma warning disable CS0114 // 'MatarDbContext.Users' hides inherited member 'IdentityUserContext<User, string, IdentityUserClaim<string>, IdentityUserLogin<string>, IdentityUserToken<string>>.Users'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.
        public DbSet<User> Users { get; set; }
#pragma warning restore CS0114 // 'MatarDbContext.Users' hides inherited member 'IdentityUserContext<User, string, IdentityUserClaim<string>, IdentityUserLogin<string>, IdentityUserToken<string>>.Users'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.
        #endregion
    }
}
