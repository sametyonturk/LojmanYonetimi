using LojmanYonetimi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace LojmanYonetimi.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Kampus> Kampus => Set<Kampus>();
        public DbSet<OdaTipi> OdaTipis => Set<OdaTipi>();
        public DbSet<ApplicationUser> ApplicationUser => Set<ApplicationUser>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);


        }
    }

}
