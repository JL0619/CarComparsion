using System;
using System.Collections.Generic;
using System.Text;
using CarComparison1.Entities;
using CarComparison1.Data;

namespace CarComparison1.Services
{
    public class CarService : ICarService
    {
        private readonly IRepository _repository;
        public CarService(IRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Car> GetAlphabetizedVehicles()
        {
            var car = _repository.GetAlphabetizedVehicles();
            return car;
        }

        public double GetAverageMPG(int year)
        {
            double MPG = _repository.GetAverageMPG(year);
            return MPG;
        }

        public Car GetBestValue()
        {
            Car car = _repository.GetBestValue();
            return car;
        }

        public double GetFuelConsumption(double distance, string model)
        {
            double consumption = _repository.GetFuelConsumption(distance,model);
            return consumption;
        }

        public Car GetNewestVehicles()
        {
            Car car = _repository.GetNewestVehicles();
            return car;
        }

        public Car GetRamdomCar()
        {
            Car car = _repository.GetRamdomCar();
            return car;
        }

        public IEnumerable<Car> GetVehiclesByPrice()
        {
            var car = _repository.GetVehiclesByPrice();
            return car;
        }
    }
}
