using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Domain.Interfaces;
using LigaAmatorska.Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Infrastructure.Repositories
{
    internal class ZawodnikRepository : IZawodnikRepository
    {
        private readonly LigaDbContext _dbContext;

        public ZawodnikRepository(LigaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task DodajZawodnika(Zawodnik zawodnik)
        {
            _dbContext.Zaowdnicy.Add(zawodnik);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Zawodnik>> GetAllAsync()
        {
            return await _dbContext.Zaowdnicy.ToListAsync();
        }

        public async Task<Zawodnik> GetByIdAsync(int id)
        {
            return await _dbContext.Zaowdnicy
                .FirstAsync(z => z.id == id);
        }
    }
}