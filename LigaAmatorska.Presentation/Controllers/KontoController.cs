using LigaAmatorska.Controllers;
using LigaAmatorska.Presentation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LigaAmatorska.Presentation.Controllers
{
    public class KontoController : Controller
    {
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
                if (model.Haslo == "admin")
                {
                    LoginViewModel.zalogowano = true;
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