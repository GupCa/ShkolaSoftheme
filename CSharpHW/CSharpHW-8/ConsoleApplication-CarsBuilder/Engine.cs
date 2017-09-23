namespace ConsoleApplication_CarsBuilder
{
    public class Engine
    {
        public int TypeOfEngine { get; set; }

        public override string ToString()
        {
            return TypeOfEngine.ToString();
        }
    }
}