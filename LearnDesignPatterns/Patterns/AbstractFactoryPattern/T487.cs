namespace LearnDesignPatterns.Patterns.AbstractFactoryPattern
{
    public class T487 : IEngine
    {
        private static string Name => "Tesla 487kW Engine";
        public string GetName()
        {
            return Name;
        }
    }
}