using System;

namespace Converter
{
    class Converter
    {
        private double HryvniaCal { get; set; }

        private readonly double usd;
        private readonly double eur;
        private readonly double rub;

        public Converter(double USD, double EUR, double RUB)
        {
            this.usd = USD;
            this.eur = EUR;
            this.rub = RUB;
        }

        public double Result()
        {
            int s = Convert.ToInt32(Console.ReadLine());
            int n;
            
            switch (s)
            {
                
                case 1:
                    Console.WriteLine("From hryvnia to dollar:");
                    Console.Write("Enter numbers: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    double u = n / usd;
                    Console.WriteLine($"Result: {u} dollars.");
                    break;

                case 2:
                    Console.WriteLine("From hryvnia to euro:");
                    Console.Write("Enter numbers: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    double e = n / eur;
                    Console.WriteLine($"Result: {e} euros.");
                    break;

                case 3:
                    Console.WriteLine("From hryvnia to ruble:");
                    Console.Write("Enter numbers: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    double r = n / rub;
                    Console.WriteLine($"Result: {r} rubles.");
                    break;

                case 4:
                    Console.WriteLine("From dollar to hryvnia");
                    Console.Write("Enter numbers: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    HryvniaCal = n * usd;
                    Console.WriteLine($"Result: {HryvniaCal} hryvnias.");
                    break;

                case 5:
                    Console.WriteLine("From euro to hryvnia:");
                    Console.Write("Enter numbers: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    HryvniaCal = n * eur;
                    Console.WriteLine($"Result: {HryvniaCal} hryvnias.");
                    break;

                case 6:
                    Console.WriteLine("From ruble to hryvnia:");
                    Console.Write("Enter numbers: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    HryvniaCal = n * rub;
                    Console.WriteLine($"Result: {HryvniaCal} hryvnias.");
                    break;

                default:
                    Console.WriteLine("The range of numbers is within 1 to 6!");
                    break;
            }
            return HryvniaCal;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Select the conversion you need and press the number(1-6):");
            Console.WriteLine("1.From hryvnia to dollar;");
            Console.WriteLine("2.From hryvnia to euro;");
            Console.WriteLine("3.From hryvnia to ruble;");
            Console.WriteLine("4.From dollar to hryvnia;");
            Console.WriteLine("5.From euro to hryvnia;");
            Console.WriteLine("6.From ruble to hryvnia.");

            Converter convert = new Converter(41, 40.35, 0.3);
            convert.Result();
        }
    }
}
