using LigaAmatorska.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Application.Services
{
    public interface IMeczService
    {
        Task DodajMeczAsync(Mecz mecz);

        public Task<IEnumerable<Mecz>> GetAllAsync();

        public Task<Mecz> GetByIdAsync(int id);

        public Task AktualizujWynikAsync(int id, int wynikA, int wynikB);
    }
}