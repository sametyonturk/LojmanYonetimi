using LojmanYonetimi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojmanYonetimi.Configurations
{
    public class PersonelAkrabaConfiguration : IEntityTypeConfiguration<PersonelAkraba>
    {
        public void Configure(EntityTypeBuilder<PersonelAkraba> builder)
        {
            builder.Property(k => k.KonukAdSoyad)
                   .HasMaxLength(200)
                   .IsRequired();
            builder.Property(k => k.KonukTckn)
                  .HasMaxLength(100)
                  .IsRequired(false);
            builder.Property(k => k.KonukDogumTarihi)
                   .IsRequired();
            builder.Property(k => k.ApplicationUserId)
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
                   .WithMany(u => u.PersonelAkrabas) // ApplicationUser tarafındaki koleksiyon
                   .HasForeignKey(k => k.ApplicationUserId)
                   .OnDelete(DeleteBehavior.Restrict); // Silme davranışını isteğe göre ayarlayabilirsiniz

            builder.ToTable("PersonelAkrabas");
        }
    }
}
