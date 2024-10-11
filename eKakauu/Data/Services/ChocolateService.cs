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

        public void Add(Chocolate chocolate)
        {
            _context.chocolates.Add(chocolate);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Chocolate>> GetAll()
        {
            var result = await _context.chocolates.ToListAsync();
            return result;
        }

        public Chocolate GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Chocolate Update(int id, Chocolate newChocolate)
        {
            throw new NotImplementedException();
        }
    }
}
