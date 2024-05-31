using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Application.Services
{
	internal class DruzynaService : IDruzynaService
	{
		private readonly IDruzynaRepository _druzynaRepository;

		public DruzynaService(IDruzynaRepository druzynaRepository)
		{
			_druzynaRepository = druzynaRepository;
		}

		public async Task DodajDruzyne(Druzyna druzyna)
		{
			await _druzynaRepository.DodajDruzyne(druzyna);
		}
	}
}