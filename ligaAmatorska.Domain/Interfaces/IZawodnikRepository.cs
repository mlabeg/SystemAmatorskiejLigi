using LigaAmatorska.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Domain.Interfaces
{
	public interface IZawodnikRepository
	{
		Task DodajZawodnika(Zawodnik zawodnik);

		Task<IEnumerable<Zawodnik>> GetAll();

		Task<Zawodnik> GetById(int id);
	}
}