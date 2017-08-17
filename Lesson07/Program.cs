using System;

namespace Lesson7
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("Enter a number:");
			int number = int.Parse(Console.ReadLine());
			Console.Write("Factors: ");
			while (number > 1) // convert this to while - DONE
			{
				int candidateFactor = 2;
				while (candidateFactor <= number) // convert this to while - DONE
				{
					if (number % candidateFactor == 0) // found a factor
					{
						Console.Write(candidateFactor + ", ");
						// divide number by the factor you found and assign this back to number
						// print a comma if number is still greater than 1
					}
                    // don't forget to increment factor!
                    candidateFactor++;
				}
                break;
			}
			Console.WriteLine();
		}
	}
}
