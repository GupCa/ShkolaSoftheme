namespace ConsoleApplication_CarsBuilder
{
    public class CarConstructor
    {
        public Car Construct(Engine engine, Color color, Transmission transmission)
        {
            return new Car
            {
                CarEngine = engine,
                CarColor = color,
                CarTransmission = transmission
            };
        }
        
        public void Reconstruct(Car car, Engine engine)
        {
            car.CarEngine = engine;
        }
    }
}