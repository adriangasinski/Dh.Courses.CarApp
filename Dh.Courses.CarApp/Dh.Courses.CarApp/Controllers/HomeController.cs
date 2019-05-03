using Dh.Courses.CarApp.Models;
using Dh.Courses.CarApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dh.Courses.CarApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _carRepository;

        public HomeController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Przegląd samochodów";
            var cars = _carRepository.GetAllCars().OrderBy(s => s.Company);

            var homeVM = new HomeVM()
            {
                Title = "Przegląd samochodów",
                Cars = cars.ToList()
            };

            return View(homeVM);
        }
    }
}
