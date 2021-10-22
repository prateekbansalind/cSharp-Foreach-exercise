using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstNames = new List<string>();
            string decisionVar;
            do
            {
                // Ask the user for their first name.
                Console.Write("Please enter your name: ");
                string firstName = Console.ReadLine();

                // Continue asking for their first names until there are no more.
                Console.Write("Do you want to make another entry (y/n): ");
                decisionVar = Console.ReadLine();


                firstNames.Add(firstName); 
            } while (decisionVar.ToLower() == "y");

            // Then loop through each name using foreach and tell them hello.
            foreach (string firstName in firstNames)
            {
                Console.WriteLine($"Hello, {firstName}");
            }

            Console.ReadLine();
        }
    }
}