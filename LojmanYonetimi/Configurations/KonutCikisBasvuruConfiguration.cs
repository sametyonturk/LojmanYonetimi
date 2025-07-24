using LojmanYonetimi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojmanYonetimi.Configurations
{
    public class KonutCikisBasvuruConfiguration : IEntityTypeConfiguration<KonutCikisBasvuru>
    {
        public void Configure(EntityTypeBuilder<KonutCikisBasvuru> builder)
        {

            builder.HasKey(k => k.Id);

            builder.Property(k => k.GirisTarihi)
                .IsRequired();

            builder.Property(k => k.CikisTarihi)
                .IsRequired();

            builder.Property(k => k.BasvuruTarihi)
                .IsRequired();

            builder.Property(k => k.CikisBasvuruDurumEnum)
                .HasConversion<string>()                // Enum string saklanır
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(k => k.Aciklama)
                .HasMaxLength(500);
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


            // 🔗 Tahsis ilişkisi (bir tahsisin çıkış başvurusu olabilir)
            builder.HasOne(k => k.Tahsis)
                .WithMany()
                .HasForeignKey(k => k.TahsisId)
                .OnDelete(DeleteBehavior.Restrict);

            // 🔗 Basvuru ilişkisi (çıkış başvurusu, mevcut başvuruya bağlıysa)
            builder.HasOne(k => k.Basvuru)
                .WithMany()
                .HasForeignKey("BasvuruId")             // FK manuel belirtiyoruz
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("KonutCikisBasvurus");
        }
    }
}
