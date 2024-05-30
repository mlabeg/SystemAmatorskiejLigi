using ligaAmatorska.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Application.Services
{
	internal interface IDruzynaService
	{
		Task DodajDruzyne(Druzyna druzyna);
	}
}