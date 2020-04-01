using System;
using System.Collections.Generic;

namespace LearnDesignPatterns.Patterns.AbstractFactoryPattern
{
    public class AbstractFactoryExecutor : IExecutor
    {
        public void Execute()
        {
            var cmds = new ValueTuple<string, string, string>[]
            {
                ("BMW", "Professional", "Normal"),
                ("Tesla", "Normal", "Normal"),
                ("TOYOTA", "Normal", "Normal"),
                ("BMW", "Air", "Professional"),
                ("Tesla", "Professional", "Edition")
            };
            foreach (var cmd in cmds)
            {
                GetAndLogProduct(cmd);
            }
        }

        private void GetAndLogProduct((string, string, string) cmd)
        {
            Console.WriteLine("Command is " + cmd);
            var factory = FactoryProducer.GetFactory(cmd.Item1);
            var res = new string[] {factory?.GetType().ToString(),factory?.GetCar(cmd.Item2)?.GetName(),
                factory?.GetEngine(cmd.Item3)?.GetName()};
            Console.WriteLine(string.Format("Factory is {0}, Car is {1}, Engine is {2}", res));
        }
    }
}