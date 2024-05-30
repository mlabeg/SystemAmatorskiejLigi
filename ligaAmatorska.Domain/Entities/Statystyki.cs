using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ligaAmatorska.Domain.Entities
{
	public class Statystyki
	{
		public int id { get; set; }
		public int minuty { get; set; }
		public int rzuty2oddane { get; set; }
		public int rzuty2celne { get; set; }
		public int rzuty3oddane { get; set; }
		public int rzuty3celne { get; set; }
		public int rzuty1oddane { get; set; }
		public int rzuty1celne { get; set; }
		public int zbiorkiOff { get; set; }
		public int zbiorkiDef { get; set; }
		public int asysty { get; set; }
		public int przechwyty { get; set; }
		public int bloki { get; set; }
		public int straty { get; set; }
		public int faule { get; set; }
		public int plusMinus { get; set; }
		public int punkty { get; set; }
		public int eval { get; set; }
	}
}