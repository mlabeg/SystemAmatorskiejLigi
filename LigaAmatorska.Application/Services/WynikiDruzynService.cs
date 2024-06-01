using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Application.Services
{
    internal class WynikiDruzynService : IWynikiDruzynService
    {
        private readonly IWynikiDruzynRepository _wynikiDruzynRepository;

        public WynikiDruzynService(IWynikiDruzynRepository wynikiDruzynRepository)
        {
            _wynikiDruzynRepository = wynikiDruzynRepository;
        }

        public async Task<int> DodajWynikiDruzynAsync(WynikiDruzyny wyniki)
        {
            await _wynikiDruzynRepository.DodajWynikiDruzynAsync(wyniki);
            return wyniki.Id;
        }

        public async Task<IEnumerable<WynikiDruzyny>> GetAllAsync()
        {
            return await _wynikiDruzynRepository.GetAllAsync();
        }

        public async Task<WynikiDruzyny> GetByIdAsync(int id)
        {
            return await _wynikiDruzynRepository.GetByIdAsync(id);
        }
    }
}