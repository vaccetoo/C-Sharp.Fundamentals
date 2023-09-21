using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace _4.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                List<string> commandParts = command.Split().ToList();

                if (commandParts[0] == "Add")
                {
                    numbers.Add(int.Parse(commandParts[1]));
                }
                else if (commandParts[0] == "Insert")
                {
                    if (int.Parse(commandParts[2]) < numbers.Count && int.Parse(commandParts[2]) >= 0)
                    {
                        numbers.Insert(int.Parse(commandParts[2]), int.Parse(commandParts[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (commandParts[0] == "Remove")
                {
                    if (int.Parse(commandParts[1]) < numbers.Count && int.Parse(commandParts[1]) >= 0)
                    {
                        numbers.RemoveAt(int.Parse(commandParts[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (commandParts[1] == "left")
                {
                    // first number becomes last. This has to be repeated the specified number of times 

                    int counter = int.Parse(commandParts[2]);

                    for (int i = 0; i < counter; i++)
                    {
                        int firstNum = numbers[0];

                        numbers.RemoveAt(0);
                        numbers.Add(firstNum);
                    }
                }
                else if (commandParts[1] == "right")
                {
                    // last number becomes first. To be repeated the specified number of times 

                    int counter = int.Parse(commandParts[2]);

                    for (int i = 0; i < counter; i++)
                    {
                        int lastNum = numbers[numbers.Count - 1];

                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, lastNum);
                    }
                }

            }

            if (command == "End")
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
