using LigaAmatorska.Domain.Entities;
using LigaAmatorska.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Infrastructure.Repositories
{
	internal class MeczRepository : IMeczRepository
	{
		public Task DodajMecz(Mecz mecz)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Mecz>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Mecz> GetById(int id)
		{
			throw new NotImplementedException();
		}
	}
}