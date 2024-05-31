using LigaAmatorska.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LigaAmatorska.Presentation.Models
{
    public class ZawodnikDruzynaViewModel : Zawodnik
    {
        public List<SelectListItem> Druzyny { get; set; }
    }
}