using LigaAmatorska.Application.Services;
using LigaAmatorska.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LigaAmatorska.Presentation.Controllers
{
    public class TeamController : Controller
    {
        private readonly IDruzynaService _druzynaService;
        private readonly IWynikiDruzynService _wynikiDruzynService;

        public TeamController(IDruzynaService druzynaService, IWynikiDruzynService wynikiDruzynService)
        {
            _druzynaService = druzynaService;
            _wynikiDruzynService = wynikiDruzynService;
        }

        [HttpGet]
        public IActionResult DodajDruzyne()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> WyswietlWszystkieDruzyny()
        {
            var druzyny = await _druzynaService.GetAllAsync();
            return View(druzyny);
        }

        public IActionResult EdytujDruzyne(int id)
        {
            var druzyna = _druzynaService.GetByIdAsync(id);
            if (druzyna == null)
            {
                return NotFound();
            }
            return View(druzyna);
        }

        [HttpPost]
        public IActionResult EdytujDruzyne(Druzyna druzyna)
        {
            if (ModelState.IsValid)
            {
                //TODO  _druzynaService.Update(druzyna);
                return RedirectToAction("WyswitlWszystkieDruzyny");
            }
            return View(druzyna);
        }

        [HttpPost]
        public async Task<IActionResult> DodajDruzyne(Druzyna druzyna)
        {
            int idWynikowDruzyn = await _wynikiDruzynService.DodajWynikiDruzynAsync(new WynikiDruzyny { });
            await _druzynaService.DodajDruzyneAsync(new Druzyna
            {
                Nazwa = druzyna.Nazwa,
                IdWynikowDruzyny = idWynikowDruzyn
            });
            return RedirectToAction("WyswietlWszystkiedruzyny");
        }

        public async Task<IActionResult> UsunDruzyne(int id)
        {
            var druzyna = await _druzynaService.GetByIdAsync(id);

            return View(druzyna);
        }

        [HttpPost]
        public async Task<IActionResult> UsunDruzyneConfirmed(int id)
        {
            await _druzynaService.RemoveByIdAsync(id);
            return RedirectToAction("WyswietlWszystkieDruzyny");
        }
    }
}