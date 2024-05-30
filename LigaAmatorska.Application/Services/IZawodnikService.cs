using ligaAmatorska.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Application.Services
{
	internal interface IZawodnikService
	{
		Task DodajZawodnika(Zawodnik zawodnik);
	}
}