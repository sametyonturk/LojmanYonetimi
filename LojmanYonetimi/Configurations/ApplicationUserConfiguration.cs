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

            // 🧍 Ad
            builder.Property(u => u.Ad)
                .HasMaxLength(50)
                .IsRequired();

            // 🧍 Soyad
            builder.Property(u => u.Soyad)
                .HasMaxLength(50)
                .IsRequired();

            // 🔒 Kurum Sicil No (benzersiz olmalı)
            builder.Property(u => u.KurumSicilNo)
                .HasMaxLength(30)
                .IsRequired();

            builder.HasIndex(u => u.KurumSicilNo)
                .IsUnique()
                .HasDatabaseName("UK_AspNetUsers_KurumSicilNo");

            // ♿ Engelli
            builder.Property(u => u.EngelliMi)
                .HasDefaultValue(false);

            // ❤️ Medeni Durum → enum string olarak saklanacak
            builder.Property(u => u.MedeniDurum)
                .IsRequired();

            // ✉️ Email
            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(256);

            builder.HasIndex(u => u.Email)
                .IsUnique();

            // 👤 UserName
            builder.Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(256);

            builder.HasIndex(u => u.NormalizedUserName)
                .IsUnique();

            // 📞 Phone Number
            builder.Property(u => u.PhoneNumber)
                .HasMaxLength(20);

            // 📧 NormalizedEmail
            builder.HasIndex(u => u.NormalizedEmail)
                .HasDatabaseName("IX_AspNetUsers_NormalizedEmail");

            // 🔐 Güvenlik ve eş zamanlılık
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();
            builder.Property(u => u.SecurityStamp).HasMaxLength(100);
        }
    }
}
