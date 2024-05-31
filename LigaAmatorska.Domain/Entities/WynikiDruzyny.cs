using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Domain.Entities
{
    public class WynikiDruzyny
    {
        public int Id { get; set; }
        public int Wygrane { get; set; }
        public int Przegrane { get; set; }
        public int PunktyDuże { get; set; }
        public int PunktyZdobyte { get; set; }
        public int PunktyStracone { get; set; }
        public int MeczeRozegrane { get; set; }
        public double PunktySrednieZdobyte { get; set; }
        public double PunktySrednieStracone { get; set; }
        public int PunktyMaxZdobyte { get; set; }
        public int PunktyMaxStracone { get; set; }
    }
}