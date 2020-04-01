namespace LearnDesignPatterns.Patterns.AbstractFactoryPattern
{
    public class BMW320i : ICar
    {
        private static string Name => "BMW 320i";

        public string GetName()
        {
            return Name;
        }
    }
}