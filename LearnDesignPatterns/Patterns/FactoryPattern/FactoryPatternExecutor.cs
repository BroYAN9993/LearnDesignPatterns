using System;
using System.Collections.Generic;
using System.Linq;

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
        private string Log(ICar car)
        {
            var name = car.GetName();
            if (name == null)
            {
                Console.WriteLine($"[Car Factory Info] This car product failed");
            }
            else
            {
                Console.WriteLine($"[Car Factory Info] This car is {name}");
            }

            return name;
        }
    }
}