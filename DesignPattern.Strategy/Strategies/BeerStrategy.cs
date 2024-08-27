using DesignPattern.UnitOfWork.Models.Data;
using DesignPattern.UnitOfWork.Models.ViewModels;
using DesignPattern.UnitOfWork.Repository;

namespace DesignPattern.Strategy.Strategies
{
    public class BeerStrategy : IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVm, IUnitOfWork unitOfWork)
        {
            var beer = new Beer();
            beer.Name = beerVm.Name;
            beer.Style = beerVm.Style;
            beer.BrandId = (Guid)beerVm.BrandId;

            unitOfWork.Beers.Add(beer);
            unitOfWork.Save();
        }
    }
}