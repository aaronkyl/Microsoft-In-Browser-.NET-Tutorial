using System;
// morning 4am - 11:59
// afternoon noon - 4:59
// evening 5 - 8:59
// night 9 - 3:59

// cannot use else or switch, only if statements
namespace Lesson6
{
    class Program
    {
        static void Main()
        {
            int currentHour = DateTime.Now.Hour;

            if (currentHour >= 4 && currentHour < 12)
            {
                Console.WriteLine("Good Morning!");
                return;
            }
            if (currentHour >= 12 && currentHour < 17)
            {
                Console.WriteLine("Good Afternoon!");
                return;
            }
            if (currentHour >= 17 && currentHour < 21)
            {
                Console.WriteLine("Good Evening!");
                return;
            }
            if ((currentHour >= 21 && currentHour < 24) || (currentHour < 4 && currentHour >= 0))
            {
                Console.WriteLine("Good Night!");
                return;
            }
            Console.WriteLine("I do not understand what hour it is...");
            return;
        }
    }
}