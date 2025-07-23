using LojmanYonetimi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojmanYonetimi.Configurations
{
    public class BasvuruConfiguration : IEntityTypeConfiguration<Basvuru>
    {
        public void Configure(EntityTypeBuilder<Basvuru> builder)
        {
            builder.Property(b => b.ApplicationUserId)
              .IsRequired();

            builder.Property(b => b.BasvuruTarihi)
                   .IsRequired();

            builder.Property(b => b.BasvuruDurum)
                   .HasConversion<string>()              // enum string olarak saklansın
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(b => b.Aciklama)
                   .HasMaxLength(500);

            builder.Property(b => b.TahsisId)
                   .IsRequired();

            builder.Property(b => b.TercihEdilenKampus)
                   .HasMaxLength(100);

            builder.Property(b => b.TercihEdilenKonut)
                   .HasMaxLength(100);

            builder.Property(b => b.TasisTuru)
                   .HasConversion<string>()              // enum string olarak saklansın
                   .HasMaxLength(30)
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


            // 🔗 Kullanıcı ilişkisi (bir user, çok başvuru)
            builder.HasOne(b => b.ApplicationUser)
            .WithMany(u => u.Basvurus)///sormak lazım
            .HasForeignKey(b => b.ApplicationUserId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Basvurus");
        }
    }
}
