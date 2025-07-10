using LojmanYonetimi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojmanYonetimi.Configurations
{
    public class KonutConfiguration : IEntityTypeConfiguration<Konut>
    {
        public void Configure(EntityTypeBuilder<Konut> builder)
        {
            builder.Property(k => k.DaireAd)
                 .HasMaxLength(100)
                 .IsRequired();
            builder.Property(k => k.Aciklama)
                  .HasMaxLength(500)
                  .IsRequired(false);
            builder.Property(p => p.BinaId)
              .IsRequired();
            builder.Property(p => p.OdaTipiId)
             .IsRequired();
            builder.Property(p => p.Esyalimi)
             .IsRequired();
            builder.Property(p => p.DaireNo)
             .IsRequired();

            builder.Property(p => p.MetreKare)
            .IsRequired();
            builder.Property(p => p.KatEnum)
            .IsRequired();
            builder.Property(p => p.IsitmaTuruEnum)
            .IsRequired();
            builder.Property(p => p.KonutDurumEnum)
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
            //builder.HasMany(k => k.Binas)
            //    .WithOne(b => b.Kampus)
            //    .HasForeignKey(b => b.KampusId)
            //    .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Konuts");
        }
    }
}
