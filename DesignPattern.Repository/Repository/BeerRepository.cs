using DesignPattern.Repository.Contracts;
using DesignPattern.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Repository.Repository
{
    internal class BeerRepository : IBeerRepositoy
    {
        private RepositoryPatternContext _context;

        public BeerRepository(RepositoryPatternContext context)
        {
            _context = context;
        }

        public void Add(Beer data) => _context.Beers.Add(data);

        public void Delete(int id)
        {
            var beer = _context.Beers.Find(id);
            _context.Beers.Remove(beer!);
        }

        public IEnumerable<Beer> Get() => _context.Beers.ToList();

        public Beer Get(int id) => _context.Beers.Find(id);

        public void Save() => _context?.SaveChanges();

        public void Update(Beer data) => _context.Entry(data).State = EntityState.Modified;
    }
}
