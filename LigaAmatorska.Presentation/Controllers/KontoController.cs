using LigaAmatorska.Controllers;
using LigaAmatorska.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace LigaAmatorska.Presentation.Controllers
{
    public class KontoController : Controller
    {
        private readonly ILogger<KontoController> _logger;

        public KontoController(ILogger<KontoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Haslo == "admin")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Nieprawidłowa nazwa użytkownika lub hasło");
                }
            }
            return View(model);
        }
    }
}