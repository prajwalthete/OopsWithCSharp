namespace abstrction_With_Interface
{

    public interface Ishape
    {
        double CalculateArea();
    }

    class Circle : Ishape
    {
        private double Radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(10);
            Console.WriteLine(c.CalculateArea());
        }
    }

}