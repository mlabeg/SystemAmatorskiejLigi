using LigaAmatorska.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Domain.Interfaces
{
    public interface IDruzynaRepository
    {
        Task DodajDruzyneAsync(Druzyna druzyna);

        Task<IEnumerable<Druzyna>> GetAllAsync();

        Task<Druzyna> GetByIdAsync(int id);

        public Task RemoveByIdAsync(int id);

        public Task<Druzyna> GetByIdStatystykAsync(int id);
    }
}