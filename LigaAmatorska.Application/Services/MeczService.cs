using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Application.Services
{
    internal class MeczService : IMeczService
    {
        private readonly IMeczRepository _meczRepository;

        public MeczService(IMeczRepository meczRepository)
        {
            _meczRepository = meczRepository;
        }

        public async Task DodajMeczAsync(Mecz mecz)
        {
            await _meczRepository.DodajMeczAsync(mecz);
        }

        public async Task<IEnumerable<Mecz>> GetAllAsync()
        {
            return await _meczRepository.GetAllAsync();
        }

        public async Task<Mecz> GetByIdAsync(int id)
        {
            return await _meczRepository.GetByIdAsync(id);
        }

        public async Task AktualizujWynikAsync(int id, int wynikA, int wynikB)
        {
            await _meczRepository.AktualizujWynikAsync(id, wynikA, wynikB);
        }
    }
}