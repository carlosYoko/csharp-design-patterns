using DesignPattern.Strategy.Strategies;
using DesignPattern.UnitOfWork.Models.ViewModels;
using DesignPattern.UnitOfWork.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesignPattern.UnitOfWork.Controllers
{
    public class BeerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BeerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<BeerViewModel> beers = from d in _unitOfWork.Beers.Get()
                                               select new BeerViewModel
                                               {
                                                   Id = d.Id,
                                                   Name = d.Name,
                                                   Style = d.Style,
                                               };
            return View("Index", beers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            GetBrandsData();
            return View();
        }

        [HttpPost]
        public IActionResult Add(FormBeerViewModel beerVm)
        {
            if (!ModelState.IsValid)
            {
                GetBrandsData();
                return View("Add", beerVm);
            }
            var context = beerVm.BrandId == null ?
                            new BeerContext(new BeerWithBrandStrategy()) :
                            new BeerContext(new BeerStrategy());

            context.Add(beerVm, _unitOfWork);

            return RedirectToAction("Index");
        }

        #region Helpers
        private void GetBrandsData()
        {
            var brands = _unitOfWork.Brands.Get();
            ViewBag.Brands = new SelectList(brands, "BrandId", "Name");

        }
        #endregion
    }
}
