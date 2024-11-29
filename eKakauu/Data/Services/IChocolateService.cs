using eKakauu.Models;

namespace eKakauu.Data.Services
{
    public interface IChocolateService
    {
        Task<IEnumerable<Chocolate>> GetAllAsync();
        Task<Chocolate> GetByIdAsync(int id);
        Task AddAsync(Chocolate chocolate);
        Task<Chocolate> UpdateAsync(int id, Chocolate newChocolate);
        Task DeleteAsync(int id);
    }
}
