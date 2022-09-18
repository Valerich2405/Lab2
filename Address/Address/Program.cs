using System;

namespace Address
{
    internal class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public string Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public string House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public string Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }

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
            address.Index = "02000";
            address.Country = "Ukraine";
            address.City = "Kyiv";
            address.Street = "Lobachevsky";
            address.House = "23";
            address.Apartment = "510";
            address.Print();
        }
    }
}
