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

        public void AddRow(Car car)
        {
            carContext.Cars.Add(car);
            carContext.SaveChanges();
        }

        public void RemoveRow(string plate)
        {
            carContext.Cars.Remove(carContext.Cars.FirstOrDefault(t => t.plate == plate));
            carContext.SaveChanges();
        }

        public void Update(Car car)
        {
            carContext.Cars.Update(car);
            carContext.SaveChanges();
        }
    }
}
