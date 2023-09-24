
List<int> houses = Console.ReadLine()
    .Split("@", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string command = string.Empty;

int lastIndex = 0;
int currIndex = 0;


while ((command = Console.ReadLine()) != "Love!")
{
    List<string> jumpCommand = command.Split(" ").ToList();
    
    int jumpLength = int.Parse(jumpCommand[1]);
    currIndex = lastIndex + jumpLength;

    if (currIndex > houses.Count - 1)
    {
        currIndex = 0;
    }

    if (houses[currIndex] == 0)
    {
        Console.WriteLine($"Place {currIndex} already had Valentine's day.");
        lastIndex = currIndex;
        continue;
    }

    houses[currIndex] -= 2;

    if (houses[currIndex] == 0)
    {
        Console.WriteLine($"Place {currIndex} has Valentine's day.");
    }

    lastIndex = currIndex;
}

Console.WriteLine($"Cupid's last position was {lastIndex}.");

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
  
    