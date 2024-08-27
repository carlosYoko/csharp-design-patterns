using DesignPattern.UnitOfWork.Models.Data;
using DesignPattern.UnitOfWork.Models.ViewModels;
using DesignPattern.UnitOfWork.Repository;

namespace DesignPattern.Strategy.Strategies
{
    public class BeerWithBrandStrategy : IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVm, IUnitOfWork unitOfWork)
        {
            var beer = new Beer();
            beer.Name = beerVm.Name;
            beer.Style = beerVm.Style;

            var brand = new Brand();
            brand.Name = beerVm.OtherBrand;
            brand.Id = Guid.NewGuid();
            beer.BrandId = brand.Id;

            unitOfWork.Brands.Add(brand);
            unitOfWork.Beers.Add(beer);
            unitOfWork.Save();
        }
    }
}
