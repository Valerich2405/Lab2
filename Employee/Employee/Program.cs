using System;

namespace Employee
{
    class Employee
    {
        private readonly string name;
        private readonly string surname;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void Salary()
        {
            int post;
            int experience;
            double salary;
            double tax;

            Console.WriteLine("Enter position:");
            Console.WriteLine("1.Junior Software Engineer;");
            Console.WriteLine("2.Middle Software Engineer;");
            Console.WriteLine("3.Senior Software Engineer.");
            post = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter experience(years):");
            Console.WriteLine("Junior Software Engineer(1-2)");
            Console.WriteLine("Middle Software Engineer(3-4)");
            Console.WriteLine("Senior Software Engineer(5+)");
            experience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Name: {name}.");
            Console.WriteLine($"Surname: {surname}.");

            if (post == 1 && experience == 1)
            {
                salary = 27000;
                tax = salary * 0.18;
                Console.WriteLine("Position: Junior Software Engineer.");
                Console.WriteLine($"Experience: {experience} year.");
                Console.WriteLine($"Salary: {salary} hryvnias.");
                Console.WriteLine($"Tax: {tax} hryvnias.");
            }

            if (post == 1 && experience == 2)
            {
                salary = 33000;
                tax = salary * 0.18;
                Console.WriteLine("Position: Junior Software Engineer.");
                Console.WriteLine($"Experience: {experience} years.");
                Console.WriteLine($"Salary: {salary} hryvnias.");
                Console.WriteLine($"Tax: {tax} hryvnias.");
            }

            if (post == 2 && experience == 3)
            {
                salary = 70000;
                tax = salary * 0.18;
                Console.WriteLine("Position: Middle Software Engineer.");
                Console.WriteLine($"Experience: {experience} years.");
                Console.WriteLine($"Salary: {salary} hryvnias.");
                Console.WriteLine($"Tax: {tax} hryvnias.");
            }

            if (post == 2 &&experience == 4)
            {
                salary = 90000;
                tax = salary * 0.18;
                Console.WriteLine("Position: Middle Software Engineer.");
                Console.WriteLine($"Experience: {experience} years.");
                Console.WriteLine($"Salary: {salary} hryvnias.");
                Console.WriteLine($"Tax: {tax} hryvnias.");
            }

            if (post == 3 && experience >= 5)
            {
                salary = 170000;
                tax = salary * 0.18;
                Console.WriteLine("Position: Senior Software Engineer.");
                Console.WriteLine($"Experience: {experience} years.");
                Console.WriteLine($"Salary: {salary} hryvnias.");
                Console.WriteLine($"Tax: {tax} hryvnias.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name:");
            string a = Console.ReadLine();

            Console.WriteLine("Enter a surname:");
            string b = Console.ReadLine();

            Employee employee = new Employee(a, b);
            employee.Salary();
        }
    }
}
