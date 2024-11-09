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
            await _context.chocolates.AddAsync(chocolate);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Chocolate>> GetAllAsync()
        {
            var result = await _context.chocolates.ToListAsync();
            return result;
        }

        public async Task<Chocolate> GetByIdAsync(int id)
        {
            var resul = await _context.chocolates.FirstOrDefaultAsync(n => n.Id == id);
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
