using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Infrastructure.Presistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LigaAmatorska.Domain.Interfaces;

namespace LigaAmatorska.Infrastructure.Repositories
{
    internal class WynikiDruzynRepository: IWynikiDruzynRepository
    {
        private readonly LigaDbContext _dbContext;

        public WynikiDruzynRepository(LigaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> DodajWynikiDruzyn(WynikiDruzyny wyniki)
        {
            _dbContext.Add(wyniki);
            await _dbContext.SaveChangesAsync();
            return wyniki.Id;
        }

    }
}
