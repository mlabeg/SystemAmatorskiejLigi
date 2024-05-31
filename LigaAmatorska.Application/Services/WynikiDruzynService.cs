using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Application.Services
{
    internal class WynikiDruzynService : IWynikiDruzynService
    {
        private readonly IWynikiDruzynRepository _wynikiDruzynRepository;

        public WynikiDruzynService(IWynikiDruzynRepository wynikiDruzynRepository)
        {
            _wynikiDruzynRepository = wynikiDruzynRepository;
        }

        public async Task<int> DodajWynikiDruzyn(WynikiDruzyny wyniki)
        {
            _wynikiDruzynRepository.DodajWynikiDruzyn(wyniki);
            return wyniki.Id;
        }
    }
}