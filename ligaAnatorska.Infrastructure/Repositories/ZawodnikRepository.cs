using ligaAmatorska.Domain.Entities;
using ligaAmatorska.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ligaAnatorska.Infrastructure.Repositories
{
	internal class ZawodnikRepository : IZawodnikRepository
	{
		public Task DodajZawodnika(Zawodnik zawodnik)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Zawodnik>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Zawodnik> GetById(int id)
		{
			throw new NotImplementedException();
		}
	}
}