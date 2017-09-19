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
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = Convert.ToDateTime(dateOfBirth);
            this.TaxPayerId = taxPayerId;
            this.HomeAddress.StreetAddress = streetAddress;
            this.HomeAddress.City = city;
            this.HomeAddress.State = state;
            this.HomeAddress.PostalCode = postalCode;
            this.HomeAddress.Country = country;
        }

        // Methods
        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }		
    }
}
