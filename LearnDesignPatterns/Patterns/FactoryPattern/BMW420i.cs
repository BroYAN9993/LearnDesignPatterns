namespace LearnDesignPatterns.Patterns.FactoryPattern
{
    public class BMW420i : ICar
    {
        public string Name
        {
            get => "BMW 420i";
        }
        public string GetName()
        {
            return Name;
        }
    }
}