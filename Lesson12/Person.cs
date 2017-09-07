using System;

namespace Lesson12
{
    public class Person
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string TaxPayerId { get; set; }
		public Address HomeAddress = new Address();

        // Constructor
        public Person(string firstName, string lastName, string dateOfBirth, string taxPayerId, string streetAddress = "", string city = "", 
                     string state = "", int postalCode = 0, string country = "")
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = Convert.ToDateTime(dateOfBirth);
            TaxPayerId = taxPayerId;
            HomeAddress.StreetAddress = streetAddress;
            HomeAddress.City = city;
            HomeAddress.State = state;
            HomeAddress.PostalCode = postalCode;
            HomeAddress.Country = country;
        }

        // Methods
        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }		
    }
}
