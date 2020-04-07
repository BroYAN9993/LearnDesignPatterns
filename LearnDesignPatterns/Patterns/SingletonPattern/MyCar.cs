using System;
using System.Threading;

namespace LearnDesignPatterns.Patterns.SingletonPattern
{
    public class MyCar
    {
        private static MyCar car = new MyCar();
        private int mileage;

        private MyCar()
        {
            Console.WriteLine("[Singleton Pattern Info] instance is building");
            mileage = 0;
        }

        public static MyCar GetMyCar()
        {
            return car;
        }

        public void Drive(int distance)
        {
            Console.WriteLine("Driving....");
            Thread.Sleep(10 * distance);
            mileage += distance;
            Console.WriteLine($"Arrived at distination: distance is {distance}, mileage is {mileage}");
        }
    }
}