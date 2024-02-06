using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_used_cars
{
    internal class Car
    {
        //prop
         public string Make {  get; set; }
         public string Model { get; set; }
         public int Year { get; set; }
         public decimal Price { get; set; }

        //no argruement constructor
        public Car ()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;
        }

        //Constrcuter
        public Car(string _make, string _model, int _year, decimal _price)
        {
            Make = _make;
            Model = _model;
            Year = _year;
            Price = _price;
        }
        //methods
        public string ToString()
        {
            string details = $"{Make} \t\t\t{Model} \t\t\t {Year} \t\t\t {Price}";
            return details;
        }
    }
}
