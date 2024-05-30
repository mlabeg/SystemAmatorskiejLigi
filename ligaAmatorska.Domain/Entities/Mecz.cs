using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Domain.Entities
{
	public class Mecz
	{
		public int id { get; set; }
		public DateTime dataGodzina { get; set; }
		public int idDruzynaA { get; set; }
		public int idDruzynaB { get; set; }
		public int wynikA { get; set; }
		public int wynikB { get; set; }
		public int idSedzia { get; set; }
	}
}