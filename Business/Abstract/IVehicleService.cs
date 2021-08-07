using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVehicleService
    {
        IEnumerable<Car> GetAllCars();
        IEnumerable<Car> GetCarsByColor(string color);
        IEnumerable<Bus> GetAllBuses();
        IEnumerable<Bus> GetBusesByColor(string color);
        IEnumerable<Boat> GetAllBoats();
        IEnumerable<Boat> GetBoatsByColor(string color);
        Car TurnOnOrOffTheLights(Guid id);
        IEnumerable<Car> DeleteCar(Guid id);

    }
}
