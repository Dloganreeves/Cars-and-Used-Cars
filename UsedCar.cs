﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_used_cars
{
    internal class UsedCar : Car
    {
        public double Mileage { get; set; }
        
        public UsedCar(string _make, string _model, int _year, decimal _price, double _mileage)
            : base(_make, _model, _year, _price) { 
            Mileage = _mileage;
        }

        
        public override string ToString()
        {
            string details = $"{Make} \t\t\t{Model} \t\t\t {Year} \t\t\t ${Price} (Used) \t\t\t{Mileage}";
            return details;
        }
    }
}
