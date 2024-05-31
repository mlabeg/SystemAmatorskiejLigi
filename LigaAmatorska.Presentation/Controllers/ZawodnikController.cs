using LigaAmatorska.Application.Services;
using LigaAmatorska.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

/*
namespace LigaAmatorska.Presentation.Controllers
{
    public class ZawodnikController : Controller
    {
        private readonly IZawodnikService _zawodnikService;

        public ZawodnikController(IZawodnikService zawodnikService)
        {
            _zawodnikService = zawodnikService;
        }

        [HttpGet]
        public IActionResult DodajZawodnika()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DodajZawodnika(Zawodnik zawodnik)
        {
            await _zawodnikService.DodajZawodnika(zawodnik);
            return RedirectToAction("WyswietlWszystkichZawodnikow");
        }
    }
}*/