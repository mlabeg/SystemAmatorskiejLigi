using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Domain.Interfaces;
using LigaAmatorska.Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;

namespace LigaAmatorska.Infrastructure.Repositories
{
    internal class DruzynaRepository : IDruzynaRepository
    {
        private readonly LigaDbContext _dbContext;

        public DruzynaRepository(LigaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task DodajDruzyneAsync(Druzyna druzyna)
        {
            _dbContext.Druzyny.Add(druzyna);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Druzyna>> GetAllAsync()
        {
            return await _dbContext.Druzyny.ToListAsync();
        }

        public async Task<Druzyna> GetByIdAsync(int id)
        {
            return await _dbContext.Druzyny
                .FirstAsync(i => i.Id == id);
        }

        public async Task RemoveByIdAsync(int id)
        {
            var druzyna = await _dbContext.Druzyny.FirstAsync(d => d.Id == id);
            if (druzyna != null)
            {
                _dbContext.Druzyny.Remove(druzyna);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}