using LojmanYonetimi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojmanYonetimi.Configurations
{
    public class PuanKuraliConfiguration : IEntityTypeConfiguration<PuanKurali>
    {
        public void Configure(EntityTypeBuilder<PuanKurali> builder)
        {
            builder.Property(k => k.Ad)
                   .HasMaxLength(500)
                   .IsRequired();
            builder.Property(k => k.SabitPuan)
                   .HasMaxLength(500)
                   .IsRequired();
            builder.Property(k => k.KisiBasiKatSayisi)
                   .HasMaxLength(500)
                   .IsRequired();
            builder.Property(k => k.YilKatSayi)
                   .HasMaxLength(500)
                   .IsRequired();
            builder.Property(k => k.AylKatSayi)
                   .HasMaxLength(500)
                   .IsRequired();
            builder.Property(k => k.AkademikTesvikPuan)
                   .HasMaxLength(500)
                   .IsRequired();
            builder.Property(k => k.MaksimumPuan)
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


            builder.ToTable("PuanKuralis");
        }
    }
}
