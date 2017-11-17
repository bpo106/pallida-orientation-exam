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
        [Route("/add")]
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

        [HttpPost("{id}")]
        [Route("/remove")]
        public IActionResult Remove(string plate)
        {
            carRepository.RemoveRow(plate);
            return RedirectToAction("List");
        }

        [HttpGet("{id}")]
        [Route("/update")]
        public IActionResult Update([FromQuery] string plate)
        {
            return View(carRepository.carContext.Cars.Where(x => x.plate == plate).FirstOrDefault());
        }

        [HttpPost("{id}")]
        [Route("/list/update")]
        public IActionResult UpdateRow(Car newCar)
        {
            carRepository.Update(newCar);
            return RedirectToAction("List");
        }
    }
}
