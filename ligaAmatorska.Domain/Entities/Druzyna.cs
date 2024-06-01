using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Domain.Entities
{
    public class Druzyna
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int IdMenadzer { get; set; }
        public WynikiDruzyny WynikiDruzyny { get; set; }
        public int? IdWynikowDruzyny { get; set; }
    }
}