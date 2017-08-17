using System;
using System.Collections.Generic;

namespace Lesson12
{
    class MainClass
    {
        public static void Main()
        {
            Person p1 = new Person("01/14/1985")
            {
                FirstName = "Aaron",
                LastName = "Wilkinson",
                HomeAddress = new Address()
                {
                    StreetAddress = "123 Main St",
                    City = "Houston",
                    State = "TX",
                    PostalCode = 77001,
                    Country = "United States"
                }
            };

            Person p2 = new Person("01/01/1980")
            {
                FirstName = "Jared",
                LastName = "Myers",
				HomeAddress = new Address()
				{
					StreetAddress = "456 Main St",
					City = "Tulsa",
					State = "OK",
					PostalCode = 12345,
					Country = "United States"
				}
            };

            Person p3 = new Person("01/02/2012")
            {
                FirstName = "Mary",
                LastName = "Smith",
				HomeAddress = new Address()
				{
					StreetAddress = "789 Main St",
					City = "St. Louis",
					State = "MO",
					PostalCode = 98765,
					Country = "United States"
				}
            };

            List<Person> contacts = new List<Person> {p1, p2, p3};

            foreach (var person in contacts)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
                Console.WriteLine($"{person.HomeAddress.StreetAddress}");
                Console.WriteLine($"{person.HomeAddress.City}, {person.HomeAddress.PostalCode}, {person.HomeAddress.State}");
                Console.WriteLine($"{person.HomeAddress.Country}");
                Console.WriteLine();
            }
        }
    }
}
