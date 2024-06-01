using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Domain.Entities
{
    public class Aktualnosci
    {
        public int Id { get; set; }
        public string Tytul { get; set; }
        public string Tresc { get; set; }
        public DateTime DataDodania { get; set; }
    }
}