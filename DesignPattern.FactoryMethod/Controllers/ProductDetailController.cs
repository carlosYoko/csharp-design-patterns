using FactoryMethod.Tools.Earn;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.FactoryMethod.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index(decimal total)
        {
            // Factories
            LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.21m);
            ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.30m, 15);

            // Products
            var localEarn = localEarnFactory.GetEarn();
            var totalForeign = foreignEarnFactory.GetEarn();

            // Total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.foreignEarn = total + totalForeign.Earn(total);

            return View();
        }
    }
}
