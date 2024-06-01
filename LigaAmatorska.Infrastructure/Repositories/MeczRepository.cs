using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Domain.Interfaces;
using LigaAmatorska.Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Infrastructure.Repositories
{
    internal class MeczRepository : IMeczRepository
    {
        private readonly LigaDbContext _dbContext;

        public MeczRepository(LigaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task DodajMecz(Mecz mecz)
        {
            _dbContext.Mecze.Add(mecz);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Mecz>> GetAllAsync()
        {
            return await _dbContext.Mecze
                .OrderBy(m=>m.DataGodzina)
                .ToListAsync();
        }

        public async Task<Mecz> GetByIdAsync(int id)
        {
            return await _dbContext.Mecze
                .FirstAsync(m => m.Id == id);
        }

        public async Task AktualizujWynikAsync(int id, int wynikA, int wynikB)
        {
            var mecz = _dbContext.Mecze.FirstOrDefault(m => m.Id == id);//czy tu async?
            if (mecz != null)
            {
                mecz.WynikA = wynikA;
                mecz.WynikB = wynikB;
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}