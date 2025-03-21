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
        private readonly IAktualnosciService _aktualnosciService;

        public HomeController(ILogger<HomeController> logger, IDruzynaService druzynaService, IMeczService meczService, IZawodnikService zawodnikService, IStatystykiService statystykiService, IWynikiDruzynService wynikiDruzynService, IAktualnosciService aktualnosciService)
        {
            _logger = logger;
            _druzynaService = druzynaService;
            _meczService = meczService;
            _zawodnikService = zawodnikService;
            _statystykiService = statystykiService;
            _wynikiDruzynService = wynikiDruzynService;
            _aktualnosciService = aktualnosciService;
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
        }

        [HttpGet]
        public async Task<IActionResult> Zawodnicy()
        {
            var zawodnicy = await _zawodnikService.GetAllAsync();
            return View(zawodnicy);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTeamsPlayers(int idDruzyny)
        {
            var zawodnicy = await _zawodnikService.GetByDruzynaAsync(idDruzyny);
            return View(zawodnicy);
        }

        [HttpGet]
        public async Task<IActionResult> Tabela() //TODO stworzyć serwis i przeniesc tam logike
        {
            var tabela = await _wynikiDruzynService.GetAllAsync();
            List<TabelaDruzynaViewModel> tDVM = new List<TabelaDruzynaViewModel>();
            foreach (var t in tabela)
            {
                var nazwa = await _druzynaService.GetByIdStatystykAsync(t.Id);
                if (nazwa != null)
                {
                    tDVM.Add(new TabelaDruzynaViewModel
                    {
                        Nazwa = nazwa.Nazwa,
                        Wyniki = t
                    });
                }
            }
            return View(tDVM);
        }

        [HttpGet]
        public async Task<IActionResult> Harmonogram()
        {
            var harmonogram = await _meczService.GetAllAsync();

            foreach (var m in harmonogram)
            {
                m.DruzynaA = await _druzynaService.GetByIdAsync(m.IdDruzynaA);
                m.DruzynaB = await _druzynaService.GetByIdAsync(m.IdDruzynaB);
            }
            return View(harmonogram);
        }

        /*
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
        }*/

        public IActionResult StronaWBudowie()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Aktualnosci()
        {
            var aktualnosci = await _aktualnosciService.GetAllAsync();
            return View(aktualnosci);
        }

        [HttpGet]
        public IActionResult DodajWiadomosc()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DodajWiadomosc(Aktualnosci wiadomosc)
        {
            wiadomosc.DataDodania = DateTime.Now;
            await _aktualnosciService.DodajWiadomosc(wiadomosc);
            return RedirectToAction("Aktualnosci");
        }
    }
}