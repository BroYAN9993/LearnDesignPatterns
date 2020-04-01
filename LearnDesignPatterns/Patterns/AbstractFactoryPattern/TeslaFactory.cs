namespace LearnDesignPatterns.Patterns.AbstractFactoryPattern
{
    public class TeslaFactory : AbstractCarFactory
    {
        public override ICar GetCar(string specification)
        {
            return specification switch
            {
                "Normal" => new TeslaModel3(),
                "Professional" => new TeslaModelS(),
                _ => null
            };
        }

        public override IEngine GetEngine(string specification)
        {
            return specification switch
            {
                "Normal" => new T487(),
                "Professional" => new T577(),
                _ => null
            };
        }
    }
}