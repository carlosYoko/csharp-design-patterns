using DesignPattern.Repository.Models;
using DesignPattern.Repository.Models.Data;
using DesignPattern.Repository.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DesignPattern.Repository.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<Beer> _repository;


        public HomeController(ILogger<HomeController> logger, IRepository<Beer> repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index()
        {

            IEnumerable<Beer> beers = _repository.Get();

            return View("Index", beers);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
