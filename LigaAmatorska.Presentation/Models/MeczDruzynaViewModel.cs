using LigaAmatorska.Domain.Entities;

namespace LigaAmatorska.Presentation.Models
{
    public class MeczDruzynaViewModel
    {
        public string NazwaDruzynyA { get; set; }
        public string NazwaDruzynyB { get; set; }
        public Mecz Mecz { get; set; }
    }
}