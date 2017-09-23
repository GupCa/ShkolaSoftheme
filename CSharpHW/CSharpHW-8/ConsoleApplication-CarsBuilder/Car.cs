namespace ConsoleApplication_CarsBuilder
{
    public class Car
    {
        public Engine CarEngine { get; set; }
        public Color CarColor { get; set; }
        public Transmission CarTransmission { get; set; }

        public override string ToString()
        {
            return  $"Engine: {CarEngine}\nColor: {CarColor}\nTransmission: {CarTransmission}\n";
        }
    }
}