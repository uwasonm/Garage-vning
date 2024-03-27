using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖvning
{
    internal class Vehicle
    {
        public string name { get; set; }
        public string numberplate { get; set; }
        public string color { get; set; }
        public int wheels { get; set; }

        public Vehicle()
        {
            name = "nothing yet";
            numberplate = "nothing yet";
            color = string.Empty;
            wheels = 0;
        }
        public Vehicle(string a, string b, string c, int d)
        {
            name = a;
            numberplate = b;
            color = c;
            wheels = d;
        }

        override public string ToString()
        {
            return "Vehicle: " + name + " " + numberplate + " " + color + " " + wheels;
        }


        class Airplane : Vehicle
        {
            public int engines = 4;
        }
        class Motorcycle : Vehicle
        {
            public int length = 2;
        }

        class Car : Vehicle
        {
            public int cylinders = 6;
        }
        class Bus : Vehicle
        {
            public int seats = 45;
        }
        class Boat : Vehicle
        {
            public string fueltype = "Gasoline";
        }

    }
}
