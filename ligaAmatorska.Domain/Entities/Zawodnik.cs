using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Domain.Entities
{
	public class Zawodnik
	{
		public int id { get; set; }
		public string nazwisko { get; set; }
		public string imie { get; set; }
		public int numer { get; set; }
		public DateTime dataUrodzenia { get; set; }
		public int idStatystyk { get; set; }
		public int idDruzyny { get; set; }
	}
}