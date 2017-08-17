using System;
using System.Collections.Generic;

namespace Lesson9
{
	class MainClass
	{
        static List<string> groceryList = new List<string>();
		public static void Main()
		{
			while (true)
			{
                printInstructions();
                string userInput = Console.ReadLine();
                string command = userInput.Substring(0, 2);
                string item = userInput.Substring(2);
				if (userInput == "exit") break;
                updateList(command, item);
                printList(groceryList);
			}
			return;
		}

        static void printInstructions()
        {
			Console.WriteLine("Enter 'exit' to quit");
			Console.Write("Enter command (+ item, - item, or -- to clear): ");
        }

		static void printList(List<string> list)
		{
			Console.WriteLine();
			Console.WriteLine("Grocery List");
			Console.WriteLine("============");
			list.ForEach(Console.WriteLine);
			Console.WriteLine();
			return;
		}

        static void addItem(string item)
        {
            groceryList.Add(item);
            return;
        }

        static void removeItem(string item)
        {
            groceryList.Remove(item);
            return;
        }

        static void clearList()
        {
			groceryList.Clear();
            return;
        }

        static void printInvalid()
        {
			Console.WriteLine();
			Console.WriteLine("*** Invalid command entered. ***");
			Console.WriteLine();
            return;
        }

        static void updateList(string command, string item)
        {
			if (command == "+ ")
			{
				addItem(item);
			}
			else if (command == "- ")
			{
				removeItem(item);
			}
			else if (command == "--")
			{
				clearList();
			}
			else
			{
				printInvalid();
			}
            return;
        }
	}
}
