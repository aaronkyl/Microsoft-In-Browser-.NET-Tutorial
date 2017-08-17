using System;

namespace Lesson12
{
    public class Person
    {
        public Person(string dateOfBirth)
        {
            DateTime DateOfBirth = Convert.ToDateTime(dateOfBirth);
        }

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public DateTime DateOfBirth { get; set; }
		public string TaxPayerId { get; set; } = string.Empty;
        public Address HomeAddress = new Address();
    }
}
