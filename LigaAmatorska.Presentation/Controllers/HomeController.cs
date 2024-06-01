﻿using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Domain.Interfaces;
using LigaAmatorska.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LigaAmatorska.Application.Services;
using Microsoft.EntityFrameworkCore;
using LigaAmatorska.Presentation.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LigaAmatorska.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDruzynaService _druzynaService;
        private readonly IMeczService _meczService;
        private readonly IZawodnikService _zawodnikService;
        private readonly IStatystykiService _statystykiService;
        private readonly IWynikiDruzynService _wynikiDruzynService;

        public HomeController(ILogger<HomeController> logger, IDruzynaService druzynaService, IMeczService meczService, IZawodnikService zawodnikService, IStatystykiService statystykiService, IWynikiDruzynService wynikiDruzynService)
        {
            _logger = logger;
            _druzynaService = druzynaService;
            _meczService = meczService;
            _zawodnikService = zawodnikService;
            _statystykiService = statystykiService;
            _wynikiDruzynService = wynikiDruzynService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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

        [HttpGet]
        public async Task<IActionResult> DodajZawodnika()
        {
            var druzyny = await _druzynaService.GetAllAsync();
            var zawodnikDruzyna = new ZawodnikDruzynaViewModel
            {
                Druzyny = druzyny.Select(d => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Value = d.Id.ToString(),
                    Text = d.Nazwa
                }).ToList()
            };
            return View(zawodnikDruzyna);
        }

        [HttpPost]
        public async Task<IActionResult> DodajZawodnika(ZawodnikDruzynaViewModel zawodnikDruzyna)
        {
            //if (ModelState.IsValid)
            //{
            int idStat = await _statystykiService.DodajStatytyki(new Statystyki { });

            await _zawodnikService.DodajZawodnika(new Zawodnik
            {
                nazwisko = zawodnikDruzyna.nazwisko,
                imie = zawodnikDruzyna.imie,
                dataUrodzenia = zawodnikDruzyna.dataUrodzenia,
                numer = zawodnikDruzyna.numer,
                idDruzyny = zawodnikDruzyna.idDruzyny,
                idStatystyk = idStat
            });

            return RedirectToAction("ZawodnicyDruzyny", new { idDruzyny = zawodnikDruzyna.idDruzyny });
            /*}

            return View(zawodnikDruzyna);*/
        }

        [HttpGet]
        public async Task<IActionResult> Zawodnicy()
        {
            var zawodnicy = await _zawodnikService.GetAllAsync();
            return View(zawodnicy);
        }

        [HttpGet]
        public async Task<IActionResult> ZawodnicyDruzyny(int idDruzyny)
        {
            var zawodnicy = await _zawodnikService.GetByDruzynaAsync(idDruzyny);
            return View(zawodnicy);
        }

        [HttpGet]
        public async Task<IActionResult> Tabela()
        {
            var tabela = await _wynikiDruzynService.GetAllAsync();
            return View(tabela);
        }
    }
}