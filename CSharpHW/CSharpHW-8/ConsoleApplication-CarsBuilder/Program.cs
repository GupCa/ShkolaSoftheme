using System;
using System.Collections.Generic;

namespace ConsoleApplication_CarsBuilder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var engine = new Engine {TypeOfEngine = 32};
            var color = new Color {ColorOfCar = "red"};
            var transmission = new Transmission {NumberTransmission = 203};
            
            var carConstrurt = new CarConstructor();

            var car = carConstrurt.Construct(engine, color, transmission);
            Console.WriteLine(car);
            
            var engineType2 = new Engine {TypeOfEngine = 586};
            carConstrurt.Reconstruct(car, engineType2);
            Console.WriteLine(car);
        }
    }
}