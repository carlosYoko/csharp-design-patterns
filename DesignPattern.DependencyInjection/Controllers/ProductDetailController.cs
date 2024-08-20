using FactoryMethod.Tools.Earn;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.DependencyInjection.Controllers
{
    public class ProductDetailController : Controller
    {
        private EarnFactory _localEarnFactory;
        private ForeignEarnFactory _foreignEarnFactory;

        public ProductDetailController(EarnFactory localEarnFactory, ForeignEarnFactory foreignEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
        }

        public IActionResult Index(decimal total)
        {

            ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.30m, 15);

            // Products
            var localEarn = _localEarnFactory.GetEarn();
            var totalForeign = foreignEarnFactory.GetEarn();

            // Total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.foreignEarn = total + totalForeign.Earn(total);

            return View();
        }
    }
}
