using System;
using System.Reflection;

namespace _01._29._2023HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car cr = new Car()
            {
                Brand = "Audi",
                Model = "R8 Spyder",
                Mileage = 5000,
                FuelCapacity = 79,
                CurrentFuel = 40.25,
            };
            cr.AddFuel(30.5);
            Console.WriteLine("Currentfuel: "+ cr.CurrentFuel);
            
            
        }
    }
}
