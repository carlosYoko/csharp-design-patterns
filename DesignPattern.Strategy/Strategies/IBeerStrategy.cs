using DesignPattern.UnitOfWork.Models.ViewModels;
using DesignPattern.UnitOfWork.Repository;

namespace DesignPattern.Strategy.Strategies
{
    public interface IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVm, IUnitOfWork unitOfWork);
    }
}
