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

        public DbSet<Unvan> Unvans => Set<Unvan>();
        public DbSet<Bina> Binas => Set<Bina>();
        public DbSet<Konut> Konuts => Set<Konut>();
        public DbSet<Gorev> Gorevs => Set<Gorev>();
        public DbSet<Birim> Birims => Set<Birim>();
        public DbSet<PersonelAkraba> PersonelAkrabas => Set<PersonelAkraba>();
        public DbSet<ApplicationUser> ApplicationUsers => Set<ApplicationUser>();
        public DbSet<PuanKurali> PuanKuralis => Set<PuanKurali>();
        public DbSet<KullaniciPuan> KullaniciPuans => Set<KullaniciPuan>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);


        }
    }

}
