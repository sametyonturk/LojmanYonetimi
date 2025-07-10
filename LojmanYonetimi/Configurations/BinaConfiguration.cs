using LojmanYonetimi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojmanYonetimi.Configurations
{
    public class BinaConfiguration : IEntityTypeConfiguration<Bina>
    {
        public void Configure(EntityTypeBuilder<Bina> builder)
        {
            builder.Property(k => k.BinaAd)
                  .HasMaxLength(100)
                  .IsRequired();
            builder.Property(k => k.BinaNo)
                  .HasMaxLength(50)
                  .IsRequired();
            builder.Property(k => k.Aciklama)
                  .HasMaxLength(500)
                  .IsRequired();
            builder.Property(k => k.AsansorVarmi)
                  .IsRequired();
            builder.Property(k => k.CatiVarmi)
                .IsRequired();
            builder.Property(k => k.EngelliGirisiVarmi)
                .IsRequired();
            builder.Property(k => k.OtoparkVarmi)
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
            builder.HasMany(k => k.Konuts)
                .WithOne(b => b.Bina)
                .HasForeignKey(b => b.BinaId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Binas");
        }
    }
}
