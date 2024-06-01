using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Application.Services
{
    internal class DruzynaService : IDruzynaService
    {
        private readonly IDruzynaRepository _druzynaRepository;

        public DruzynaService(IDruzynaRepository druzynaRepository)
        {
            _druzynaRepository = druzynaRepository;
        }

        public async Task DodajDruzyneAsync(Druzyna druzyna)
        {
            await _druzynaRepository.DodajDruzyneAsync(druzyna);
        }

        public async Task<IEnumerable<Druzyna>> GetAllAsync()
        {
            return await _druzynaRepository.GetAllAsync();
        }

        public async Task<Druzyna> GetByIdAsync(int id)
        {
            return await _druzynaRepository.GetByIdAsync(id);
        }

        public async Task RemoveByIdAsync(int id)
        {
            await _druzynaRepository.RemoveByIdAsync(id);
        }
    }
}