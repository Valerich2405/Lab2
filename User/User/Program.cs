using System;

namespace User
{
    class User
    {
        public string Login;
        public string Name;
        public string Surname;
        public int Age;
        public string Date;

        public void Information()
        {
            Console.WriteLine("Enter your login:");
            Login = Console.ReadLine();

            Console.WriteLine("Enter your name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter your surname:");
            Surname = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            Age = Convert.ToInt32(Console.ReadLine());

            Date = DateTime.Now.ToString();

            Console.WriteLine();
            Console.WriteLine($"Your login: {Login};");
            Console.WriteLine($"Your name: {Name} {Surname};");
            Console.WriteLine($"Your age: {Age};");
            Console.WriteLine($"Date of filling out the questionnaire: {Date}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Information();
        }
    }
}
