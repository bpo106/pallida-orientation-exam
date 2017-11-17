using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LicensePlateManager.Repositories;
using LicensePlateManager.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LicensePlateManager.Controllers
{
    public class CarController : Controller
    {
        CarRepository carRepository;

        public CarController(CarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        [Route("/")]
        [Route("/list")]
        [HttpGet]
        public IActionResult List()
        {
            return View(carRepository.carContext.Cars);
        }

        [HttpGet]
        [Route("/search")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/add")]
        public IActionResult Add(Car car)
        {
            carRepository.AddRow(car);
            return RedirectToAction("List");
        }
    }
}
