using System.Data;

List<int> wagons = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

int maxCapacityOfWagon = int.Parse(Console.ReadLine());

string command = string.Empty;

while ((command = Console.ReadLine()) != "end")
{
    string[] input = command.Split().ToArray();

    if (input.Length > 1)
    {
        wagons.Add(int.Parse(input[1]));
    }
    else if (input.Length <= 1)
    {
        for (int i = 0; i < wagons.Count; i++)
        {
            if (wagons[i] + int.Parse(input[0]) <= maxCapacityOfWagon)
            {
                wagons[i] += int.Parse(input[0]);
                break;
            }
        }
    }
}

if (command == "end")
{
    Console.WriteLine(string.Join(" ", wagons));
}