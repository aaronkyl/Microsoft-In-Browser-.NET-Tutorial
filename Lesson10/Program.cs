using System;
using System.Collections.Generic;

namespace Lesson10
{
    class MainClass
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };
            int sum = 0;
            Console.Write("Numbers:");
            foreach (var num in numbers)
            {
                Console.Write($" {num}");
                sum += num;
            }
            Console.WriteLine();
            Console.Write($"Sum: {sum}");
            return;
        }
    }
}
