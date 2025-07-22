using LojmanYonetimi.Entities;
using LojmanYonetimi.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace LojmanYonetimi.Data
{
    public static class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var date = new DateTime(2025, 7, 15, 10, 0, 0);

           

            // Bina
            modelBuilder.Entity<Bina>().HasData(
                new Bina { Id = 1, KampusId = 1, BinaAd = "A Blok", BinaNo = "A1", Aciklama = "Açıklama A", Ekleyen = "system", Duzenleyen = "system", EklemeTarihi = date, DuzenlemeTarihi = date, Silinmismi = false, Aktif = true },
                new Bina { Id = 2, KampusId = 1, BinaAd = "B Blok", BinaNo = "B1", Aciklama = "Açıklama B", Ekleyen = "system", Duzenleyen = "system", EklemeTarihi = date, DuzenlemeTarihi = date, Silinmismi = false, Aktif = true },
                new Bina { Id = 3, KampusId = 2, BinaAd = "Online Ofis", BinaNo = "C1", Aciklama = "Online açıklama", Ekleyen = "system", Duzenleyen = "system", EklemeTarihi = date, DuzenlemeTarihi = date, Silinmismi = false, Aktif = true }
            );

            // Oda Tipi
            modelBuilder.Entity<OdaTipi>().HasData(
                new OdaTipi { Id = 1, OdaAd = "1+1", Ekleyen = "system", Duzenleyen = "system", EklemeTarihi = date, DuzenlemeTarihi = date, Silinmismi = false, Aktif = true },
                new OdaTipi { Id = 2, OdaAd = "2+1", Ekleyen = "system", Duzenleyen = "system", EklemeTarihi = date, DuzenlemeTarihi = date, Silinmismi = false, Aktif = true }
            );

            // Konut
            modelBuilder.Entity<Konut>().HasData(
                new Konut { Id = 1, BinaId = 1, OdaTipiId = 1, KatEnum = KatEnum.Kat1, DaireNo = 101, DaireAd = "101 No'lu Daire", KonutDurumEnum = KonutDurumEnum.Bos, Ekleyen = "system", Duzenleyen = "system", EklemeTarihi = date, DuzenlemeTarihi = date, Silinmismi = false, Aktif = true }
            );

            // Birim
            modelBuilder.Entity<Birim>().HasData(
                new Birim { Id = 1, BirimAd = "Bilgi İşlem", Ekleyen = "system", Duzenleyen = "system", EklemeTarihi = date, DuzenlemeTarihi = date, Aktif = true, Silinmismi = false }
            );

            // Görev
            modelBuilder.Entity<Gorev>().HasData(
                new Gorev { Id = 1, GorevAd = "Memur", Ekleyen = "system", Duzenleyen = "system", EklemeTarihi = date, DuzenlemeTarihi = date, Aktif = true, Silinmismi = false }
            );

            // Unvan
            modelBuilder.Entity<Unvan>().HasData(
                new Unvan { Id = 1, UnvanAd = "Uzman", Ekleyen = "system", Duzenleyen = "system", EklemeTarihi = date, DuzenlemeTarihi = date, Aktif = true, Silinmismi = false }
            );

            // Puan Kuralı
            modelBuilder.Entity<PuanKurali>().HasData(
                new PuanKurali {
                    Id = 1,
                    Kod = "PK001",
                    Ad = "Kıdem Puanı",
                    SabitPuan = 10,
                    KisiBasiKatSayisi = 0,
                    YilKatSayi = 0,
                    AylKatSayi = 0,
                    AkademikTesvikPuan = 0,
                    MaksimumPuan = 100,
                    Aciklama = "Kıdeme göre verilen puan",

                    Ekleyen = "system",
                    Duzenleyen = "system",
                    EklemeTarihi = date,
                    DuzenlemeTarihi = date,
                    Aktif = true,
                    Silinmismi = false
                }
            );

            // Kullanıcı Puan
            modelBuilder.Entity<KullaniciPuan>().HasData(
                new KullaniciPuan { Id = 1, ApplicationUserId = 1, PuanKuraliId = 1, Puan = 10, Ekleyen = "system", Duzenleyen = "system", EklemeTarihi = date, DuzenlemeTarihi = date, Aktif = true, Silinmismi = false }
            );
        }

        public static void SeedIdentity(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            var role = new ApplicationRole { Name = "Admin", NormalizedName = "ADMIN" };
            if (!roleManager.RoleExistsAsync(role.Name).Result)
                roleManager.CreateAsync(role).Wait();

            var user = new ApplicationUser
            {
                UserName = "admin@site.com",
                Email = "admin@site.com",
                EmailConfirmed = true
            };

            var result = userManager.CreateAsync(user, "Admin123*").Result;
            if (result.Succeeded)
                userManager.AddToRoleAsync(user, role.Name).Wait();
        }
    }
}
