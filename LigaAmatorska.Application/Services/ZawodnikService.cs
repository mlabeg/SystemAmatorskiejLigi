using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Application.Services
{
    internal class ZawodnikService : IZawodnikService
    {
        private readonly IZawodnikRepository _zawodnikRepository;

        public ZawodnikService(IZawodnikRepository zawodnikRepository)
        {
            _zawodnikRepository = zawodnikRepository;
        }

        public async Task DodajZawodnika(Zawodnik zawodnik)
        {
            await _zawodnikRepository.DodajZawodnika(zawodnik);
        }

        public async Task<IEnumerable<Zawodnik>> GetAllAsync()
        {
            return await _zawodnikRepository.GetAllAsync();
        }

        public async Task<Zawodnik> GetByIdAsync(int id)
        {
            return await _zawodnikRepository.GetByIdAsync(id);
        }
    }
}