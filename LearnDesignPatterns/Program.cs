using System;
using LearnDesignPatterns.Patterns.FactoryPattern;

namespace LearnDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var factoryPatternExecutor = new FactoryPatternExecutor();
            factoryPatternExecutor.Execute();
        }
    }
}