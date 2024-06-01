using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Domain.Entities
{
    public class Mecz
    {
        public int Id { get; set; }
        public DateTime DataGodzina { get; set; }
        public int IdDruzynaA { get; set; }
        public int IdDruzynaB { get; set; }
        public int WynikA { get; set; }
        public int WynikB { get; set; }
        public int? IdSedzia { get; set; }
    }
}