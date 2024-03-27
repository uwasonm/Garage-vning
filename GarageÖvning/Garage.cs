using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖvning
{
    internal class Garage
    {
        public List <Vehicle> ParkedVehicles { get; set; }
        public List<Vehicle> LeavingVehicles { get; set; }


        public Garage()
        {
           ParkedVehicles= new List<Vehicle>();
           LeavingVehicles = new List<Vehicle>();
        }

        public int Count()
        {
            int number = 0;
            foreach (var item in ParkedVehicles)
            {
                number=number+1;
            }
            ParkedVehicles.Clear();
            return number;
        }
    }
}
