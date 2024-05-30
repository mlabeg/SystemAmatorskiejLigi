using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ligaAmatorska.Domain.Entities
{
	public class Druzyna
	{
		public int id { get; set; }
		public string nazwa { get; set; }
		public int idMenadzer { get; set; }
	}
}