using System;
using LearnDesignPatterns.Patterns.AbstractFactoryPattern;
using LearnDesignPatterns.Patterns.FactoryPattern;

namespace LearnDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var factoryPatternExecutor = new FactoryPatternExecutor();
            factoryPatternExecutor.Execute();
            var abstractFactoryExecutor = new AbstractFactoryExecutor();
            abstractFactoryExecutor.Execute();
        }
    }
}