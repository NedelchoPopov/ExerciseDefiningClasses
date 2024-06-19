﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CarSalesman
{
    public class Engine
    {
        public Engine(string model, string power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = null;
            this.Efficiency = "n/a";
        }

        public Engine(string model, string power, int displacement)
           : this(model, power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model, string power, string efficiency)
          : this(model, power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, string power, int displacement, string efficiency)
            : this(model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public string Model { get; set; }
        public string Power { get; set; }
        public int? Displacement { get; set; }
        public string Efficiency { get; set; }
    }
}
