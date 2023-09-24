
List<int> houses = Console.ReadLine()
    .Split("@", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string command = string.Empty;

int startIndex = 0;
int currIndex = 0;


while ((command = Console.ReadLine()) != "Love!")
{
    List<string> jumpCommand = command.Split(" ").ToList();
    
    int jumpLength = int.Parse(jumpCommand[1]);

    if (startIndex + jumpLength > houses.Count - 1)
    {
        startIndex = 0;
        jumpLength = 0;
    }

    if (houses[startIndex + jumpLength] == 0)
    {
        Console.WriteLine($"Place {startIndex + jumpLength} already had Valentine's day.");
        continue;
    }

    houses[startIndex + jumpLength] -= 2;

    if (houses[startIndex + jumpLength] == 0)
    {
        Console.WriteLine($"Place {startIndex + jumpLength} has Valentine's day.");
    }

    currIndex = startIndex + jumpLength;
    startIndex = currIndex;
}

Console.WriteLine($"Cupid's last position was {currIndex}.");

if (houses.Sum() == 0)
{
    Console.WriteLine("Mission was successful.");
}
else
{
    int counter = 0;

    for (int i = 0; i < houses.Count; i++)
    {
        if (houses[i] != 0)
        {
            counter++;
        }
    }

    Console.WriteLine($"Cupid has failed {counter} places.");
}
  