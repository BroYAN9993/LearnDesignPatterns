namespace LearnDesignPatterns.Patterns.AbstractFactoryPattern
{
    public class B48 : IEngine
    {
        private static string Name => "BMW B48 Engine";
        public string GetName()
        {
            return Name;
        }
    }
}