using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace LearnDesignPatterns.Patterns.FactoryPattern
{
    public class FactoryPatternExecutor : IExecutor
    {
        public void Execute()
        {
            var carFactory = new CarFactory();
            var cars = new List<ICar>()
            {
                carFactory.GetCar("BMW"),
                carFactory.GetCar("TESLA"),
                carFactory.GetCar("TOYOTA")
            };
            foreach (var s in cars) Log(s);
        }
        private static void Log(ICar car)
        {
            Console.WriteLine(car == null
                ? $"[Car Factory Info] This car product failed"
                : $"[Car Factory Info] This car is {car.GetName()}");
        }
    }
}