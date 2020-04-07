using System;
using LearnDesignPatterns.Patterns.AbstractFactoryPattern;
using LearnDesignPatterns.Patterns.FactoryPattern;
using LearnDesignPatterns.Patterns.SingletonPattern;

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
            var singletonPatternExecutor = new SingletonPatternExecutor();
            singletonPatternExecutor.Execute();
        }
    }
}