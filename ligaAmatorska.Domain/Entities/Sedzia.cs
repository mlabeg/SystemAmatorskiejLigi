using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ligaAmatorska.Domain.Entities
{
	public class Sedzia
	{
		public int id { get; set; }
		public string imie { get; set; }
		public string nazwisko { get; set; }
		public string adresEmail { get; set; }
		public string numerTelefonu { get; set; }
		public int numerLicncji { get; set; }
	}
}