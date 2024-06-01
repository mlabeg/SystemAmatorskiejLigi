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
    internal class AktualnosciRepository : IAktualnosciRepository
    {
        private readonly LigaDbContext _dbContext;

        public AktualnosciRepository(LigaDbContext ligaDbContext)
        {
            _dbContext = ligaDbContext;
        }

        public async Task DodajWiadomoscAsync(Aktualnosci aktualnosci)
        {
            _dbContext.Aktualnoscis.Add(aktualnosci);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Aktualnosci>> GetAllAsync()
        {
            return await _dbContext.Aktualnoscis
                .OrderByDescending(a => a.DataDodania)
                .ToListAsync();
        }

        public async Task<Aktualnosci> GetByIdAsync(int id)
        {
            return await _dbContext.Aktualnoscis.FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}