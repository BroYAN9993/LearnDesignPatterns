namespace LearnDesignPatterns.Patterns.AbstractFactoryPattern
{
    public class BMWFactory : AbstractCarFactory
    {
        public override ICar GetCar(string specification)
        {
            return specification switch
            {
                "Normal" => new BMW320i(),
                "Professional" => new BMW420i(),
                _ => null
            };
        }

        public override IEngine GetEngine(string specification)
        {
            return specification switch
            {
                "Normal" => new N20(),
                "Professional" => new B48(),
                _ => null
            };
        }
    }
}