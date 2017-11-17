using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LicensePlateManager.Repositories;
using LicensePlateManager.Models;
using System.Collections.Generic;

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
        [Route("/search")]
        [HttpGet]
        public IActionResult Search()
        {
            return View(carRepository.carContext.Cars);
        }

        [Route("/search")]
        [HttpGet("{brand}")]
        public IActionResult Search(string brand)
        {
            return View(carRepository.carContext.Cars.Where(x => x.car_brand == brand));
            //Yet it returns with some error 500 because I cannot manage DBset string/normal string conversion
        }
    }
}
