using LojmanYonetimi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojmanYonetimi.Configurations
{
    public class CikisEksikKaydiConfiguration : IEntityTypeConfiguration<CikisEksikKaydi>
    {
        public void Configure(EntityTypeBuilder<CikisEksikKaydi> builder)
        {
            

            builder.HasKey(e => e.Id);

            builder.Property(e => e.KonutCikisBasvuruId)
                   .IsRequired();

            builder.Property(e => e.Aciklama)
                   .HasMaxLength(500)
                   .IsRequired();

            builder.Property(e => e.Giderildimi)
                   .HasDefaultValue(false)
                   .IsRequired();

            builder.Property(e => e.EkleenmeTarihi)
                   .IsRequired();

            builder.Property(e => e.GiderilmeTarihi)
                   .IsRequired(false); // Eğer giderilmemişse null olabilir

            builder.Property(e => e.GeriBildirim)
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


            builder.HasOne(e => e.KonutCikisBasvuru)
                   .WithMany() // Eğer KonutCikisBasvuru tarafında ICollection yoksa
                   .HasForeignKey(e => e.KonutCikisBasvuruId)
                   .OnDelete(DeleteBehavior.Cascade);
           

            builder.ToTable("CikisEksikKaydis");
        }
    }
}
