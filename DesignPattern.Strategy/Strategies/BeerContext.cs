using DesignPattern.UnitOfWork.Models.ViewModels;
using DesignPattern.UnitOfWork.Repository;

namespace DesignPattern.Strategy.Strategies
{
    public class BeerContext
    {
        private IBeerStrategy _strategy;
        public IBeerStrategy Strategy
        {
            set { _strategy = value; }
        }

        public BeerContext(IBeerStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Add(FormBeerViewModel beerVm, IUnitOfWork unitOfWork)
        {
            _strategy.Add(beerVm, unitOfWork);
        }
    }
}
