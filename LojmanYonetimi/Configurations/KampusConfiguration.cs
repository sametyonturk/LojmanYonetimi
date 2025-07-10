using LojmanYonetimi.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LojmanYonetimi.Configurations
{
    public class KampusConfiguration : IEntityTypeConfiguration<Kampus>
    {
        public void Configure(EntityTypeBuilder<Kampus> builder)
        {
            

            builder.Property(k => k.KampusAd)
                   .HasMaxLength(500)
                   .IsRequired();

            // BaseEntity alanları için de istersen burada yapılandırma yapılabilir.
            builder.Property(p => p.Ekleyen)
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(p => p.Duzenleyen)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.EklemeTarihi).IsRequired();
            builder.Property(p => p.DuzenlemeTarihi).IsRequired();

            builder.Property(p => p.Aktif).HasDefaultValue(true);
            builder.Property(p => p.Silinmismi).HasDefaultValue(false);


            // Bire-çok ilişki
            builder.HasMany(k => k.Binas)
                .WithOne(b => b.Kampus)
                .HasForeignKey(b => b.KampusId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Kampus");
        }
    }
}
