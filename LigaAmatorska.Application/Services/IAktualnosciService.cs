using LigaAmatorska.Domain.Entities;

namespace LigaAmatorska.Application.Services
{
    internal interface IAktualnosciService
    {
        Task DodajWiadomosc(Aktualnosci aktualnosci);

        Task<IEnumerable<Aktualnosci>> GetAllAsync();

        Task<Aktualnosci> GetById(int id);
    }
}