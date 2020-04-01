namespace LearnDesignPatterns.Patterns.AbstractFactoryPattern
{
    public class TeslaModelS : ICar
    {
        private static string Name => "Tesla Model S";

        public string GetName()
        {
            return Name;
        }
    }
}