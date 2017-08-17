using System;

namespace Lesson12
{
    public class Address
    {
        public string StreetAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public int PostalCode { get; set; } = 0;
        public string Country { get; set; } = string.Empty;

        public void PrintAddress()
        {
			Console.WriteLine($"{StreetAddress}");
			Console.WriteLine($"{City}, {PostalCode}, {State}");
			Console.WriteLine($"{Country}");
        }
    }
}
