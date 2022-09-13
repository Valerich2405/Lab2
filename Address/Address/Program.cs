using System;

namespace Address
{
    internal class Address
    {
        public string index;
        public string country;
        public string city;
        public string street;
        public string house;
        public string apartment;

        public void Print()
        {
            Console.WriteLine($"Index: {index};");
            Console.WriteLine($"Country: {country};");
            Console.WriteLine($"City: {city};");
            Console.WriteLine($"Street: {street};");
            Console.WriteLine($"House: {house};");
            Console.WriteLine($"Apartment: {apartment}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.index = "02000";
            address.country = "Ukraine";
            address.city = "Kyiv";
            address.street = "Lobachevsky";
            address.house = "23";
            address.apartment = "510";
            address.Print();
        }
    }
}
