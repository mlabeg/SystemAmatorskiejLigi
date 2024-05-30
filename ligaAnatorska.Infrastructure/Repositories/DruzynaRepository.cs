using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Domain.Interfaces;

namespace LigaAmatorska.Infrastructure.Repositories
{
	internal class DruzynaRepository : IDruzynaRepository
	{
		public Task DodajDruzyne(Druzyna druzyna)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Druzyna>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Druzyna> GetById(int id)
		{
			throw new NotImplementedException();
		}
	}
}