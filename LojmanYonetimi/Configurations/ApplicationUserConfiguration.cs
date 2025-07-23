using LojmanYonetimi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojmanYonetimi.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("ApplicationUsers");

            builder.Property(u => u.Ad)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(u => u.Soyad)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.KurumSicilNo)
                .IsRequired()
                .HasMaxLength(20);

            builder.HasIndex(u => u.KurumSicilNo)
                .IsUnique();

            builder.Property(u => u.EngelliMi)
                .HasDefaultValue(false);

            builder.Property(u => u.MedeniDurum)
                .HasConversion<string>()
                .HasMaxLength(20)
                .IsRequired();

         

            // Identity varsayılan alanlar
            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(256);

            builder.HasIndex(u => u.Email).IsUnique();

            builder.Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(256);

            builder.HasIndex(u => u.NormalizedUserName).IsUnique();

            builder.Property(u => u.PhoneNumber)
                .HasMaxLength(20);

            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();
            builder.Property(u => u.SecurityStamp).HasMaxLength(100);
        }
    }
}
