using Business.Abstract;
using Entities;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   public class VehicleManager : IVehicleService
    {
        
        
        public IEnumerable<Car> DeleteCar(Guid id)
        {
            var car = Repository.Cars.FirstOrDefault(car => car.Id == id);
            Repository.Cars.Remove(car);
            return Repository.Cars;
        }

        public IEnumerable<Boat> GetAllBoats()
        {
            return Repository.Boats;
        }

        public IEnumerable<Bus> GetAllBuses()
        {
            return Repository.Buses;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return Repository.Cars;
        }

        public IEnumerable<Boat> GetBoatsByColor(string color)
        {
            return Repository.Boats.Where(boat => boat.Color == color.Trim().ToLower());
        }

        public IEnumerable<Bus> GetBusesByColor(string color)
        {
            return Repository.Buses.Where(bus => bus.Color == color.Trim().ToLower());
        }

        public IEnumerable<Car> GetCarsByColor(string color)
        {
            return Repository.Cars.Where(car => car.Color == color.Trim().ToLower());
        }

        public Car TurnOnOrOffTheLights(Guid id)
        {
            var car = Repository.Cars.FirstOrDefault(car => car.Id == id);
            if (car==null)
            {
                return null;
            }
            car.Headlights = !car.Headlights;
            return car;
        }
    }
}
