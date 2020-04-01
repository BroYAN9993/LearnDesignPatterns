namespace LearnDesignPatterns.Patterns.AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public static AbstractCarFactory GetFactory(string brand)
        {
            return brand switch
            {
                "BMW" => new BMWFactory(),
                "Tesla" => new TeslaFactory(),
                _ => null
            };
        }
    }
}