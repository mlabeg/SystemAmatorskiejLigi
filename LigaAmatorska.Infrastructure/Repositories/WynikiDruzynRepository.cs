using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Infrastructure.Presistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LigaAmatorska.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LigaAmatorska.Infrastructure.Repositories
{
    internal class WynikiDruzynRepository : IWynikiDruzynRepository
    {
        private readonly LigaDbContext _dbContext;

        public WynikiDruzynRepository(LigaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> DodajWynikiDruzynAsync(WynikiDruzyny wyniki)
        {
            _dbContext.Add(wyniki);
            await _dbContext.SaveChangesAsync();
            return wyniki.Id;
        }

        public async Task<IEnumerable<WynikiDruzyny>> GetAllAsync()
        {
            return await _dbContext.WynikiDruzynies
                .AsQueryable()
                .OrderByDescending(x => x.PunktyDuże)
                .OrderByDescending(x => x.PunktyZdobyte)
                .ToListAsync();
        }

        public async Task<WynikiDruzyny> GetByIdAsync(int id)
        {
            return await _dbContext.WynikiDruzynies.FirstAsync(w => w.Id == id);
        }
    }
}