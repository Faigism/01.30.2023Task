using System;
using System.Collections.Generic;
using System.Text;

namespace _01._29._2023HomeTask
{
    internal class Car:Vehicle
    {
        public double FuelCapacity;
        public double CurrentFuel;

        public void AddFuel(double fuel)
        {
            double capacity = CurrentFuel + fuel;
            if (capacity<=FuelCapacity)
            {
                CurrentFuel += fuel;
            }
        }
    }

    
}
