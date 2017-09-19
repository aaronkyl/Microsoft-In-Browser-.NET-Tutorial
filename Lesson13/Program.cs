using System;

namespace Lesson13
{
    class MainClass
    {
        public static void Main()
        {
            Student aaron = new Student("Aaron", "Wilkinson", new DateTime(1985, 01, 14));
            Student susan = new Student("Susan", "Wallace", new DateTime(1984, 11, 28));

            var calculus = new Course("Calculus");

            calculus.AddStudent(aaron);
            calculus.AddStudent(susan);
            calculus.PrintRoster();
            Console.WriteLine();
            calculus.Rename("Calc I");
            calculus.PrintRoster();
        }
    }
}
