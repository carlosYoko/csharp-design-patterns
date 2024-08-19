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

            // Products
            var localEarn = localEarnFactory.GetEarn();

            // Total
            ViewBag.totalLocal = total + localEarn.Earn(total);

            return View();
        }
    }
}
