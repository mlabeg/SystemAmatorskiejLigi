using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Domain.Interfaces;
using LigaAmatorska.Infrastructure.Presistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Infrastructure.Repositories
{
    internal class StatystykiRepository : IStatystykiRepository
    {
        private readonly LigaDbContext _dbContext;

        public StatystykiRepository(LigaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task DodajStatystyki(Statystyki statystyki)
        {
            _dbContext.Add(statystyki);
            await _dbContext.SaveChangesAsync();
        }
    }
}
