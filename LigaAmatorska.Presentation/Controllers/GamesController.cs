using LigaAmatorska.Application.Services;
using LigaAmatorska.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LigaAmatorska.Presentation.Controllers
{
    public class GamesController : Controller
    {
        private readonly IMeczService _meczService;

        public GamesController(IMeczService meczService)
        {
            _meczService = meczService;
        }

        [HttpGet]
        public IActionResult DodajMecz()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DodajMecz(Mecz mecz)
        {
            await _meczService.DodajMeczAsync(mecz);
            return RedirectToAction("Harmonogram");
        }

        [HttpGet]
        public async Task<IActionResult> AktualizujWynikMeczu(int id)
        {
            var mecz = await _meczService.GetByIdAsync(id);
            return View(mecz);
        }

        [HttpPost]
        public async Task<IActionResult> AktualizujWynikMeczu(Mecz mecz)
        {
            if (ModelState.IsValid)
            {
                await _meczService.AktualizujWynikAsync(mecz.Id, mecz.WynikA, mecz.WynikB);
                return RedirectToAction("Harmonogram");
            }
            return View(mecz);
        }
    }
}