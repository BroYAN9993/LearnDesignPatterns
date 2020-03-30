namespace LearnDesignPatterns.Patterns.FactoryPattern
{
    public class TeslaModel3 : ICar
    {
        public string Name
        {
            get => "Tesla Model III";
        }
        public string GetName()
        {
            return Name;
        }
    }
}