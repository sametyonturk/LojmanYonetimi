using LojmanYonetimi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojmanYonetimi.Configurations
{
    public class BirimConfiguration : IEntityTypeConfiguration<Birim>
    {
        public void Configure(EntityTypeBuilder<Birim> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.BirimAd)
                .IsRequired()
                .HasMaxLength(150);

            builder.HasOne(b => b.UstBirim)
                .WithMany(b => b.AltBirimler)
                .HasForeignKey(b => b.UstBirimId)
                .OnDelete(DeleteBehavior.Restrict); // önemli!


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
                .WithOne(b => b.Birim)
                .HasForeignKey(b => b.BirimId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Birims");
        }
    }
}
