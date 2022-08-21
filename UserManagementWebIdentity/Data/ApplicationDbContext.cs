using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserManagementWebIdentity.Models;

namespace UserManagementWebIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {


        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

/*        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
             options.UseSqlServer("Server=(localdb)\\ProjectModels;Database=aspnet-UserManagementWebIdentity;Trusted_Connection=True;MultipleActiveResultSets=true");
*/
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().ToTable("Users", "security");
            builder.Entity<IdentityRole>().ToTable("Roles", "security");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "security");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "security");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "security");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "security");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "security");

            builder.Entity<ApplicationUser>()
                .Property(e => e.ProfilePicture)
                .IsRequired(false);
        }

        public string GetUserName(string email)
        {
            var username = this.Users.Single(e => e.Email == email).UserName;
            return username;
        }
    }
}