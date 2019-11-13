using CarComparison1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarComparison1.Services
{
    public interface ICarService
    {
        Car GetNewestVehicles();
        IEnumerable<Car> GetAlphabetizedVehicles();
        IEnumerable<Car> GetVehiclesByPrice();
        Car GetBestValue();
        double GetFuelConsumption(double distance, string model);
        Car GetRamdomCar();
        double GetAverageMPG(int year);
    }
}
