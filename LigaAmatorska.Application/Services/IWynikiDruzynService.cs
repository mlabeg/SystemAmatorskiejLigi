using LigaAmatorska.Domain.Entities;

namespace LigaAmatorska.Application.Services
{
    public interface IWynikiDruzynService
    {
        Task<int> DodajWynikiDruzynAsync(WynikiDruzyny wyniki);

        public Task<IEnumerable<WynikiDruzyny>> GetAllAsync();

        public Task<WynikiDruzyny> GetByIdAsync(int id);
    }
}