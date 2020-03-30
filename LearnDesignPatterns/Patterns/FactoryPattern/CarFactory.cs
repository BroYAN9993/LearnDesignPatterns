namespace LearnDesignPatterns.Patterns.FactoryPattern
{
    public class CarFactory
    {
        public ICar GetCar(string carType)
        {
            return carType switch
            {
                "BMW" => (ICar) new BMW420i(),
                "TESLA" => new TeslaModel3(),
                _ => null
            };
        }
    }
}