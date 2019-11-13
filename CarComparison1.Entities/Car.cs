using System;
using System.Collections.Generic;
using System.Text;

namespace CarComparison1.Entities
{
    public class Car
    {
        //public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public double TCCRating { get; set; }
        public int HwyMPG { get; set; }
    }
}
