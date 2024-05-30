using ligaAmatorska.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ligaAmatorska.Domain.Interfaces
{
	public interface IMeczRepository
	{
		Task DodajMecz(Mecz mecz);

		Task<IEnumerable<Mecz>> GetAll();

		Task<Mecz> GetById(int id);
	}
}