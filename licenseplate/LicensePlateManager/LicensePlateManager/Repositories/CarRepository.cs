using LicensePlateManager.Entities;
using LicensePlateManager.Models;
using System.Linq;

namespace LicensePlateManager.Repositories
{
    public class CarRepository
    {
        public CarContext carContext;

        public CarRepository(CarContext carContext)
        {
            this.carContext = carContext;
        }
    }
}
