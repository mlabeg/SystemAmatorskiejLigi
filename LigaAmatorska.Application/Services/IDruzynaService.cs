using LigaAmatorska.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Application.Services
{
    public interface IDruzynaService
    {
        Task DodajDruzyne(Druzyna druzyna);

        public Task<IEnumerable<Druzyna>> GetAllAsync();

        public Task<Druzyna> GetByIdAsync(int id);

        public Task RemoveByIdAsync(int id);
    }
}