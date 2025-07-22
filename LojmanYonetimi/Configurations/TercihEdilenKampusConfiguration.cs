using LojmanYonetimi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojmanYonetimi.Configurations
{
    public class TercihEdilenKampusConfiguration : IEntityTypeConfiguration<TercihEdilenKampus>
    {
        public void Configure(EntityTypeBuilder<TercihEdilenKampus> builder)
        {
            builder.Property(k => k.BasvuruId)
                  .HasMaxLength(500)
                  .IsRequired();

            builder.Property(k => k.KampusId)
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


            builder.ToTable("TercihEdilenKampus");
        }
    }
}
