namespace inheritance
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("animal eating");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("woof,woof");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
        }
    }


}

