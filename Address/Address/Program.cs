using System;

namespace Address
{
     class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public string Index { get; set;}
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

        public void Print()
        {
            Console.WriteLine($"Index: {Index};");
            Console.WriteLine($"Country: {Country};");
            Console.WriteLine($"City: {City};");
            Console.WriteLine($"Street: {Street};");
            Console.WriteLine($"House: {House};");
            Console.WriteLine($"Apartment: {Apartment}.");
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
