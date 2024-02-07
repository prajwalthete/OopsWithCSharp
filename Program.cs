namespace abstraction
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }
    class Circle : Shape
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
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