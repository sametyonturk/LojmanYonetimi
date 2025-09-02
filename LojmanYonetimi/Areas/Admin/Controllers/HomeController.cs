using LojmanYonetimi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
               // <-- gerekli
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace LojmanYonetimi.Areas.Admin.Controllers  // <-- önemli!
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]   // sadece admin
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger) => _logger = logger;

        public IActionResult Index() => View();
        // Admin’de Privacy/Error’a ihtiyacýn yoksa sil gitsin
    }
}