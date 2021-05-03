using Microsoft.EntityFrameworkCore;
using TDPC12_ASPNETCore3._1WebAppMVC.Entity;

namespace TDPC12_ASPNETCore3._1WebAppMVC.Context
{
    public class TDPC12DBContext : DbContext
    {
        public TDPC12DBContext(DbContextOptions<TDPC12DBContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}