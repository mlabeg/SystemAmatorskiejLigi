using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Application.Services
{
	internal class MeczService : IMeczService
	{
		private readonly IMeczRepository _meczRepository;

		public MeczService(IMeczRepository meczRepository)
		{
			_meczRepository = meczRepository;
		}

		public async Task DodajMecz(Mecz mecz)
		{
			await _meczRepository.DodajMecz(mecz);
		}
	}
}