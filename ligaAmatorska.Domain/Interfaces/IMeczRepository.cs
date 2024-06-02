using LigaAmatorska.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Domain.Interfaces
{
    public interface IMeczRepository
    {
        Task DodajMeczAsync(Mecz mecz);

        Task<IEnumerable<Mecz>> GetAllAsync();

        Task<Mecz> GetByIdAsync(int id);

        public Task AktualizujWynikAsync(int id, int wynikA, int wynikB);
    }
}