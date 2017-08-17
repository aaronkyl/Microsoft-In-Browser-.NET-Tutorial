using System;

namespace Lesson8
{
    class MainClass
    {
		public static void Main()
		{
            for (int counter = 1; counter <= 4; counter++)
            {
                for (int num = 0; num <= 24; num += counter)
                {
                    Console.Write(num);
                    if (num != 24){
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }
		}
    }
}
