using ligaAmatorska.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Application.Services
{
	internal class ZawodnikService : IZawodnikService
	{
		private readonly IZawodnikService _zawodnikService;

		public async Task DodajZawodnika(Zawodnik zawodnik)
		{
			await _zawodnikService.DodajZawodnika(zawodnik);
		}
	}
}