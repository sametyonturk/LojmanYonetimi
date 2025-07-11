using LojmanYonetimi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojmanYonetimi.Configurations
{
    public class KullaniciPuanConfiguration : IEntityTypeConfiguration<KullaniciPuan>
    {
        public void Configure(EntityTypeBuilder<KullaniciPuan> builder)
        {
            builder.Property(k => k.ApplicationUserId)
                   .IsRequired();
            builder.Property(k => k.PuanKuraliId)
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


         

            // ApplicationUser ile ilişki
            builder.HasOne(k => k.ApplicationUser) // Navigation property
                   .WithMany(u => u.KullaniciPuans) // ApplicationUser tarafındaki koleksiyon
                   .HasForeignKey(k => k.ApplicationUserId)
                   .OnDelete(DeleteBehavior.Restrict); // Silme davranışını isteğe göre ayarlayabilirsiniz

            // ApplicationUser ile ilişki
            builder.HasOne(k => k.PuanKurali) // Navigation property
                   .WithMany(u => u.KullaniciPuans) // ApplicationUser tarafındaki koleksiyon
                   .HasForeignKey(k => k.PuanKuraliId)
                   .OnDelete(DeleteBehavior.Restrict); // Silme davranışını isteğe göre ayarlayabilirsiniz

            builder.ToTable("KullaniciPuans");
        }
    }
}
