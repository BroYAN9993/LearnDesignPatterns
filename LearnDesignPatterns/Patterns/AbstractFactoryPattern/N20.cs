namespace LearnDesignPatterns.Patterns.AbstractFactoryPattern
{
    public class N20 : IEngine
    {
        private static string Name => "BMW N20 Engine";
        public string GetName()
        {
            return Name;
        }
    }
}