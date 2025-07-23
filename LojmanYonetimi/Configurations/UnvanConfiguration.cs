using LojmanYonetimi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojmanYonetimi.Configurations
{
    public class UnvanConfiguration : IEntityTypeConfiguration<Unvan>
    {
        public void Configure(EntityTypeBuilder<Unvan> builder)
        {
             builder.Property(k => k.UnvanAd)
                   .HasMaxLength(200)
                   .IsRequired();
            builder.Property(k => k.UnvanKisaAd)
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


            

            builder.ToTable("Unvans");
        }
    }
}
