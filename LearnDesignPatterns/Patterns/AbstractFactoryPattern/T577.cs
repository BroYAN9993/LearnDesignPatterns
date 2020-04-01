namespace LearnDesignPatterns.Patterns.AbstractFactoryPattern
{
    public class T577: IEngine
    {
        private static string Name => "Tesla 577kW Engine";
        public string GetName()
        {
            return Name;
        }
    }
}