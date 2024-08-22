using DesignPattern.UnitOfWork.Models.Data;

namespace DesignPattern.UnitOfWork.Repository
{
    public interface IUnitOfWork
    {
        public IRepository<Beer> Beers { get; }
        public IRepository<Brand> Brands { get; }
        public void Save();
    }
}
