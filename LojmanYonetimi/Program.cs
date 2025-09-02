using LojmanYonetimi.Data;
using LojmanYonetimi.Entities;
using LojmanYonetimi.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AppRole = LojmanYonetimi.Entities.ApplicationRole;
// Identity sýnýflarýný Entities'ten kullanýyoruz (alias)
using AppUser = LojmanYonetimi.Entities.ApplicationUser;
using Birim = LojmanYonetimi.Entities.Birim;

var builder = WebApplication.CreateBuilder(args);

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Identity (int key)
builder.Services
    .AddIdentity<AppUser, AppRole>(opt =>
    {
        opt.Password.RequiredLength = 6;
        opt.Password.RequireNonAlphanumeric = false;
        opt.Password.RequireUppercase = false;
    })
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

// Cookie
builder.Services.ConfigureApplicationCookie(opt =>
{
    opt.LoginPath = "/Account/Login";
    opt.AccessDeniedPath = "/Account/AccessDenied";
    opt.SlidingExpiration = true;
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

// --- Seed: Rol + Birim + Admin ---
using (var scope = app.Services.CreateScope())
{
    var ctx = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<AppRole>>();

    // 1) Rol
    if (!await roleManager.RoleExistsAsync("Admin"))
        await roleManager.CreateAsync(new AppRole { Name = "Admin" });

    // 2) Birim: Kimlik (Identity) olduðundan Id vermiyoruz
    var birim = await ctx.Birims.FirstOrDefaultAsync(b => b.BirimAd == "Bilgi Ýþlem");
    if (birim == null)
    {
        birim = new Birim
        {
            BirimAd = "Bilgi Ýþlem",

            // <<< BaseEntity/konfigürasyonunda NOT NULL olan alanlarýnýz:
            Duzenleyen = "seed",        // zorunluysa
            DuzenlemeTarihi = DateTime.Now,           // zorunluysa
            Ekleyen = "seed",        // zorunluysa
            EklemeTarihi = DateTime.Now            // zorunluysa
                                                      // baþka NOT NULL alanlar varsa burada doldurun
        };
        ctx.Birims.Add(birim);
        await ctx.SaveChangesAsync(); // birim.Id burada oluþur
    }

    // 3) Admin kullanýcý
    var admin = await userManager.FindByEmailAsync("admin@site.com");
    if (admin == null)
    {
        admin = new AppUser
        {
            UserName = "admin@site.com",
            Email = "admin@site.com",
            EmailConfirmed = true,

            Ad = "Admin",
            Soyad = "Yönetici",
            KurumSicilNo = "0001",
            EngelliMi = false,
            MedeniDurum = MedeniDurumEnum.Bekar, // property adý MedeniDurum
            BirimId = birim.Id               // otomatik oluþan Id
        };
       
        await userManager.CreateAsync(admin, "Admin123*");   // þifreyi deðiþtir
        await userManager.AddToRoleAsync(admin, "Admin");
    }
}

// Pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Routes
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapDefaultControllerRoute();

app.Run();
