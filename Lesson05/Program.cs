using System;

namespace Lesson5
{
	class Program
	{
		static void Main()
		{
			int correctNumber = new Random().Next(3) + 1;
			int guessedNumber = 0;
			while (guessedNumber != correctNumber)
			{
				Console.Write("Enter a number between 1 and 3: ");
				guessedNumber = int.Parse(Console.ReadLine());
				if (guessedNumber < 1 || guessedNumber > 3)
				{
                    Console.WriteLine("Number must be between 1 and 3! Try again!");
				}
				else if (correctNumber > guessedNumber)
				{
					Console.WriteLine("You guessed too low. Try again!");
				}
				else if (correctNumber < guessedNumber)
				{
					Console.WriteLine("You guessed too high. Try again!");
				}
			}
            Console.WriteLine("YOU WIN!");
			return;
		}
	}
}
