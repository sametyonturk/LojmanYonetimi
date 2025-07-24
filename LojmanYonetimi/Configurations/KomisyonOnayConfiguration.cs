using LojmanYonetimi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojmanYonetimi.Configurations
{
    public class KomisyonOnayConfiguration : IEntityTypeConfiguration<KomisyonOnay>
    {
        public void Configure(EntityTypeBuilder<KomisyonOnay> builder)
        {
            builder.HasKey(k => k.Id);

            // 🔗 Konut çıkış başvurusuna ilişki
            builder.HasOne(k => k.KonutCikisBasvuru)
                .WithMany() // Eğer KonutCikisBasvuru içinde ICollection<KomisyonOnay> yoksa
                .HasForeignKey(k => k.KonutCikisBasvuruId)
                .OnDelete(DeleteBehavior.Cascade);

            // 🔗 Komisyon üyesine ilişki (ApplicationUser)
            builder.HasOne(k => k.KomisyonUye)
                .WithMany() // Eğer ApplicationUser içinde ICollection<KomisyonOnay> yoksa
                .HasForeignKey(k => k.KomisyonUyeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(k => k.OnayDurumu)
                .HasConversion<string>()        // Enum string saklansın
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(k => k.Aciklama)
                .HasMaxLength(500);

            builder.Property(k => k.OnayTarihi)
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

            builder.ToTable("KomisyonOnays");

        }
    }
}
