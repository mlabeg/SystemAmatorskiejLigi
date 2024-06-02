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
        public int? Wygrane { get; set; } = 0;
        public int? Przegrane { get; set; } = 0;
        public int? PunktyDuże { get; set; } = 0;
        public int? PunktyZdobyte { get; set; } = 0;
        public int? PunktyStracone { get; set; } = 0;
        public int? MeczeRozegrane { get; set; } = 0;
        public double? PunktySrednieZdobyte { get; set; } = 0;
        public double? PunktySrednieStracone { get; set; } = 0;
        public int? PunktyMaxZdobyte { get; set; } = 0;
        public int? PunktyMaxStracone { get; set; } = 0;
    }
}