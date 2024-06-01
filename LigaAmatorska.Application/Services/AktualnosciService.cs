using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Application.Services
{
    internal class AktualnosciService : IAktualnosciService
    {
        private readonly IAktualnosciRepository _aktualnosciRepository;

        public AktualnosciService(IAktualnosciRepository aktualnosciRepository)
        {
            _aktualnosciRepository = aktualnosciRepository;
        }

        public async Task DodajWiadomosc(Aktualnosci aktualnosci)
        {
            await _aktualnosciRepository.DodajWiadomoscAsync(aktualnosci);
        }

        public async Task<IEnumerable<Aktualnosci>> GetAllAsync()
        {
            return await _aktualnosciRepository.GetAllAsync();
        }

        public async Task<Aktualnosci> GetById(int id)
        {
            return await _aktualnosciRepository.GetByIdAsync(id);
        }
    }
}