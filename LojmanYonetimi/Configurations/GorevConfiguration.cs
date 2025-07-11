using LojmanYonetimi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojmanYonetimi.Configurations
{
    public class GorevConfiguration : IEntityTypeConfiguration<Gorev>
    {
        public void Configure(EntityTypeBuilder<Gorev> builder)
        {
            builder.Property(k => k.GorevAd)
                   .HasMaxLength(200)
                   .IsRequired();
            builder.Property(k => k.GorevKisaAd)
                  .HasMaxLength(100)
                  .IsRequired(false);
            builder.Property(k => k.Sira)
                 .IsRequired();
            builder.Property(k => k.Puan)
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
            builder.HasMany(k => k.ApplicationUsers)
                .WithOne(b => b.Gorev)
                .HasForeignKey(b => b.GorevId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Gorevs");
        }
    }
}
