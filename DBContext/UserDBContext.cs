using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TDPC12_ASPNETCore3._1WebAppMVC.Entities;

namespace TDPC12_ASPNETCore3._1WebAppMVC.DBContext
{
    public class UserDBContext : IdentityDbContext<User>
    {
        public UserDBContext(DbContextOptions<UserDBContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
