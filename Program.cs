namespace encapsulation
{
    class Student
    {
        private int Id;
        private string Name;


        public int SetId(int id)
        {
            return Id = id;
        }
        public string SetName(string name)
        {
            return Name = name;
        }
        public void printDetail()
        {
            Console.WriteLine(this.Name + ": " + this.Id);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.SetId(1);
            s.SetName("Test");
            s.printDetail();

        }
    }

}