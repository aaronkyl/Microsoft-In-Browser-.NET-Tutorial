using System;
using System.Collections.Generic;

namespace Lesson9
{
    class MainClass
    {
        public static void Main()
        {
            List<string> groceryList = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter 'exit' to quit");
                Console.Write("Enter command (+ item, - item, or -- to clear)): ");
                string command = Console.ReadLine();
                if (command == "exit") break;
                else if (command.Substring(0,2) == "+ ") 
                {
                    groceryList.Add(command.Substring(2));
                    printList(groceryList);
                }
                else if (command.Substring(0, 2) == "- ")
                {
                    groceryList.Remove(command.Substring(2));
                    printList(groceryList);
                }
                else if (command.Substring(0, 2) == "--")
                {
                    groceryList.Clear();
                    printList(groceryList);
                }
                else
                {
                    Console.WriteLine("*** Invalid command entered. ***");
                    Console.WriteLine();
                }
            }
            return;
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
    }
}
