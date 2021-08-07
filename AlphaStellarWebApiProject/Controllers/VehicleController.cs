using Business.Abstract;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaStellarWebApiProject.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class VehicleController : Controller
    {
        private readonly IVehicleService _service;
        public VehicleController(IVehicleService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllCars()
        {
            return Ok(_service.GetAllCars());
        }
        
        [HttpGet]
        public IActionResult GetAllBoats()
        {
            return Ok(_service.GetAllBoats());
        }
        [HttpGet]
        public IActionResult GetAllBuses()
        {
            return Ok(_service.GetAllBuses());
        }
        [HttpGet]
        public IActionResult GetCarsByColor(string color)
        {
            return Ok(_service.GetCarsByColor(color));
        }
        [HttpGet]
        public IActionResult GetBusesByColor(string color)
        {
            return Ok(_service.GetBusesByColor(color));
        }
        [HttpGet]
        public IActionResult GetBoatsByColor(string color)
        {
            return Ok(_service.GetBoatsByColor(color));
        }
        [HttpDelete]
        public IActionResult DeleteCar(Guid id)
        {
            return Ok(_service.DeleteCar(id));
        }
        [HttpPost]
        public IActionResult TurnOnOrOffTheLights([FromBody] Car car)
        {
            return Ok(_service.TurnOnOrOffTheLights(car.Id));
        }
    }
}
