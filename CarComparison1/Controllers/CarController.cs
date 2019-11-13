using CarComparison1.Entities;
using CarComparison1.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CarComparison1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carservice;
        public CarController(ICarService carService)
        {
            _carservice = carService;
        }

        [HttpGet]
        [Route("newest")]
        public Car GetNewestVehicles()
        {
            Car car = _carservice.GetNewestVehicles();
            return car;
        }

        [HttpGet]
        [Route("alpha")]
        public IEnumerable<Car> GetAlphabetizedVehicles()
        {
            var car = _carservice.GetAlphabetizedVehicles();
            return car;
        }

        [HttpGet]
        [Route("price")]
        public IEnumerable<Car> GetVehiclesByPrice()
        {
            var car = _carservice.GetVehiclesByPrice();
            return car;
        }

        [HttpGet]
        [Route("bestvalue")]
        public Car GetBestValue()
        {
            Car car = _carservice.GetBestValue();
            return car;
        }

        [HttpGet]
        [Route("{distance}/{model}/consumption")]
        public double GetFuelConsumption(double distance, string model)
        {
            double consumption = _carservice.GetFuelConsumption(distance, model);
            return consumption;
        }

        [HttpGet]
        [Route("random")]
        public Car GetRamdomCar()
        {
            Car car = _carservice.GetRamdomCar();
            return car;
        }

        [HttpGet]
        [Route("{year}/avgmpg")]
        public double GetAverageMPG(int year)
        {
            double avgMPG = _carservice.GetAverageMPG(year);
            return avgMPG;
        }
    }
}