using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Application.Services
{
    internal class StaytstykiService:IStatystykiService
    {
        private readonly IStatystykiRepository _statystykiRepository;

        public StaytstykiService(IStatystykiRepository statystykiRepository)
        {
            _statystykiRepository = statystykiRepository;
        }

        public async Task DodajStatytyki(Statystyki staytstyki)
        {
            await _statystykiRepository.DodajStatystyki(staytstyki);
        }
    }
}
