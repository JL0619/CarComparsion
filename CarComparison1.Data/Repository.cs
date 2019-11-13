using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarComparison1.Data;
using CarComparison1.Entities;

namespace CarComparison1.Data
{

    public class Repository : IRepository
    {
        private readonly List<Car> _car;
        public Repository()
        {
            _car = new List<Car>
                {
                    new Car{ Make="Honda",Model = "CRV",Colour = "Green", Year = 2016, Price = 23845,TCCRating = 8, HwyMPG = 33 },
                    new Car{ Make="Ford",Model = "Escape",Colour = "Red", Year = 2017, Price = 23590,TCCRating = 7.8, HwyMPG = 32 },
                    new Car{ Make="Hyundai",Model = "Sante Fe",Colour = "Grey", Year = 2016, Price = 24950,TCCRating = 8, HwyMPG = 27 },
                    new Car{ Make="Mazda",Model = "CX-5",Colour = "Red", Year = 2017, Price = 21795,TCCRating = 8, HwyMPG = 35 },
                    new Car{ Make="Subaru",Model = "Forester",Colour = "Blue", Year = 2016, Price = 22395,TCCRating = 8.4, HwyMPG = 32 }
                }; 
        }

        public IEnumerable<Car> GetAlphabetizedVehicles()
        {
            return _car.OrderBy(c => c.Make).ToList();
        }

        public double GetAverageMPG(int year)
        {
            var car = _car.Where(c => c.Year == year).Average(c => c.HwyMPG);
            return car;
        }

        public Car GetBestValue()
        {
            return _car.OrderBy(c => c.Price).OrderByDescending(c => c.TCCRating).FirstOrDefault();
        }

        public double GetFuelConsumption(double distance, string model)
        {
            var car = _car.Where(c => c.Model == model).SingleOrDefault();
            var consumption = car.HwyMPG * distance;
            return consumption;
        }
        public Car GetNewestVehicles()
        {
            return _car.OrderByDescending(c => c.Year).FirstOrDefault();
        }
        public Car GetRamdomCar()
        {
            var random = new Random();
            var car = _car.OrderBy(x => random.Next()).FirstOrDefault();
            return car;
        }

        public IEnumerable<Car> GetVehiclesByPrice()
        {
            return _car.OrderBy(c => c.Price).ToList();
        }
    }
}
