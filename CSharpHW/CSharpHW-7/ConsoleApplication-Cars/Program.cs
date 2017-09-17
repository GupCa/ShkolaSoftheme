using System;
using System.Collections.Generic;

namespace ConsoleApplication_Cars
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var car = new Car
            {
                Color = Colors.Blue,
                Model = "Tesla",
                Year = 2016
            };
            car.Print();            

            TuningAlert.TuneCar(car);
            car.Print();
        }
    }
}