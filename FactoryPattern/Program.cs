using System.Runtime.InteropServices;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many wheels do you want? 2 or 4?");
            var userInput = int.Parse(Console.ReadLine());

            VehicleFactory.GetVehicle(userInput);
        }
    }
}
