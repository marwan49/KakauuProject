using eKakauu.Models;
using Microsoft.EntityFrameworkCore;

namespace eKakauu.Data.Services
{
    public class ChocolateService : IChocolateService
    {
        private readonly AppDbContext _context;

        public ChocolateService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Chocolate chocolate)
        {
            await _context.Chocolates.AddAsync(chocolate);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Chocolates.FirstOrDefaultAsync(c => c.Id == id);
            _context.Chocolates.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Chocolate>> GetAllAsync()
        {
            var result = await _context.Chocolates.ToListAsync();
            return result;
        }

        public async Task<Chocolate> GetByIdAsync(int id)
        {
            var resul = await _context.Chocolates.FirstOrDefaultAsync(n => n.Id == id);
            return resul;
        }

        public async Task<Chocolate> UpdateAsync(int id, Chocolate newChocolate)
        {
            _context.Update(newChocolate);
            await _context.SaveChangesAsync();
            return newChocolate;
        }
    }
}
