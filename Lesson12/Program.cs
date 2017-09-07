using System;
using System.Collections.Generic;

namespace Lesson12
{
    class MainClass
    {
        public static void Main()
        {
            Person p1 = new Person("Aaron", "Wilkinson", "01/14/1985", "1233", "123 Main St", "Houston", "TX", 77001, "United States");

            Person p2 = new Person("Jared", "Meyers", "01/01/1980", "1234");

            Person p3 = new Person("Mary", "Smith", "01/02/2012", "1235", "", "St. Louis");

            List<Person> contacts = new List<Person> {p1, p2, p3};

            foreach (var person in contacts)
            {
                person.PrintFullName();
                person.HomeAddress.PrintAddress();
                Console.WriteLine();
            }
        }
    }
}
