using System.Collections.Generic;
using System.Diagnostics;

class Exam
{
    static void Main()
    {
        int peopleWaiting = int.Parse(Console.ReadLine()); // 10

        int[] wagons = Console.ReadLine() // [0, 0, 0,] or [3, 4, 0, 0] or ...
            .Split()                                     // w0 w1 w2 w3
            .Select(int.Parse)
            .ToArray();

        int maxPeopleInWagon = 4;

        bool isThereEmptySpot = false;

        for (int currWagon = 0; currWagon < wagons.Length; currWagon++)
        {
            if (wagons[currWagon] < maxPeopleInWagon)
            {
                while (wagons[currWagon] < maxPeopleInWagon && peopleWaiting > 0)
                {
                    wagons[currWagon] += 1;
                    peopleWaiting -= 1;
                }
            }

            if (wagons[currWagon] < 4)
            {
                isThereEmptySpot = true;
            }
        }

        if (peopleWaiting == 0 && isThereEmptySpot)
        {
            Console.WriteLine("The lift has empty spots!");
            Console.WriteLine(string.Join(" ", wagons));
        }
        else if (peopleWaiting > 0)
        {
            Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            Console.WriteLine(string.Join(" ", wagons));
        }
        else
        {
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
