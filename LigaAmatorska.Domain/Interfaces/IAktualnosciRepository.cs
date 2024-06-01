using LigaAmatorska.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Domain.Interfaces
{
    public interface IAktualnosciRepository
    {
        public Task DodajWiadomoscAsync(Aktualnosci aktualnosci);

        public Task<IEnumerable<Aktualnosci>> GetAllAsync();

        public Task<Aktualnosci> GetByIdAsync(int id);
    }
}