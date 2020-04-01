namespace LearnDesignPatterns.Patterns.AbstractFactoryPattern
{
    public abstract class AbstractCarFactory
    {
        public abstract ICar GetCar(string specification);
        public abstract IEngine GetEngine(string specification);
    }
}