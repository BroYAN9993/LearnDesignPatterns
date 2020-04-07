using System;

namespace LearnDesignPatterns.Patterns.SingletonPattern
{
    public class SingletonPatternExecutor : IExecutor
    {
        public void Execute()
        {
            Console.WriteLine("[Singleton Pattern Info] Start point of Execute");
            var car = MyCar.GetMyCar();
            car.Drive(100);
            car.Drive(200);
            var car1 = MyCar.GetMyCar();
            car.Drive(50);
        }
    }
}