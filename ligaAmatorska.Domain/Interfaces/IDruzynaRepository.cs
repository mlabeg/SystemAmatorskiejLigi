using ligaAmatorska.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ligaAmatorska.Domain.Interfaces
{
	public interface IDruzynaRepository
	{
		Task DodajDruzyne(Druzyna druzyna);

		Task<IEnumerable<Druzyna>> GetAll();

		Task<Druzyna> GetById(int id);
	}
}