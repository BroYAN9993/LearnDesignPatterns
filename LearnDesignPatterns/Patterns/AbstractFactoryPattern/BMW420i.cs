namespace LearnDesignPatterns.Patterns.AbstractFactoryPattern
{
    public class BMW420i : ICar
    {
        private static string Name => "BMW 420i";

        public string GetName()
        {
            return Name;
        }
    }
}