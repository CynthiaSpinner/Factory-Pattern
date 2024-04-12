using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int tires)
        {
            switch (tires)
            {
                case 4:
                    Console.WriteLine("We will get you a new car!");
                    return new Car();
                case 2:
                    Console.WriteLine("We will get you a new motorcycle!");
                    return new Motorcycle();
                default:
                    Console.WriteLine("Thats not one of our choices so now you get a new car!");
                    return new Car();
            }

        }
    }
}
