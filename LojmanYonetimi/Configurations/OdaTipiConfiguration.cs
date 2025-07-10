using LojmanYonetimi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojmanYonetimi.Configurations
{
    public class OdaTipiConfiguration : IEntityTypeConfiguration<OdaTipi>
    {
        public void Configure(EntityTypeBuilder<OdaTipi> builder)
        {
            builder.Property(k => k.OdaAd)
                  .HasMaxLength(100)
                  .IsRequired();
            builder.Property(k => k.Aciklama)
                  .HasMaxLength(500)
                  .IsRequired(false);
            builder.Property(p => p.OdaSayisi)
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
            builder.HasMany(k => k.Konuts)
                .WithOne(b => b.OdaTipi)
                .HasForeignKey(b => b.OdaTipiId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("OdaTipis");
        }
    }
}
