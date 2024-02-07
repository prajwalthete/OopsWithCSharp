namespace polymorphism
{

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            // base.Draw();
            Console.WriteLine("drawing  circle");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Circle();
            s.Draw();
        }
    }



}

