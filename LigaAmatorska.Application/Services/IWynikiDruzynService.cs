using LigaAmatorska.Domain.Entities;

namespace LigaAmatorska.Application.Services
{
    public interface IWynikiDruzynService
    {
        Task<int> DodajWynikiDruzyn(WynikiDruzyny wyniki);
    }
}