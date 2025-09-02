using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// Entities'teki tipleri kullanıyoruz
using AppUser = LojmanYonetimi.Entities.ApplicationUser;

namespace LojmanYonetimi.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> _signIn;
        private readonly UserManager<AppUser> _users;

        public AccountController(UserManager<AppUser> users, SignInManager<AppUser> signIn)
        {
            _users = users;
            _signIn = signIn;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string email, string password, string? returnUrl = null)
        {
            var user = await _users.FindByEmailAsync(email);
            if (user == null)
            {
                ModelState.AddModelError("", "Geçersiz kullanıcı veya şifre.");
                return View();
            }

            var result = await _signIn.PasswordSignInAsync(user, password, false, lockoutOnFailure: true);
            if (result.Succeeded)
                return !string.IsNullOrEmpty(returnUrl) ? Redirect(returnUrl)
                    : RedirectToAction("Index", "Home", new { area = "Admin" });

            ModelState.AddModelError("", "Geçersiz kullanıcı veya şifre.");
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signIn.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

        [AllowAnonymous]
        public IActionResult AccessDenied() => Content("Erişim yok.");
    }
}
