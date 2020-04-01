namespace LearnDesignPatterns.Patterns.AbstractFactoryPattern
{
    public class TeslaModel3 : ICar
    {
        private static string Name => "Tesla Model III";

        public string GetName()
        {
            return Name;
        }
    }
}