using eKakauu.Models;

namespace eKakauu.Data.Services
{
    public interface IChocolateService
    {
        Task<IEnumerable<Chocolate>> GetAll();
        Chocolate GetById(int id);
        void Add(Chocolate chocolate);
        Chocolate Update(int id, Chocolate newChocolate);
        void Delete(int id);
    }
}
