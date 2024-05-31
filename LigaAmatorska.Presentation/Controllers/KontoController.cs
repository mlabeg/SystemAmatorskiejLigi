using LigaAmatorska.Controllers;
using LigaAmatorska.Presentation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LigaAmatorska.Presentation.Controllers
{
    public class KontoController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        public KontoController(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Logowanie()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logowanie(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.NazwaUzytkownika, model.Haslo, false, false);

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