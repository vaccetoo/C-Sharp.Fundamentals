
using System.ComponentModel.Design;

List<int> pirateShip = Console.ReadLine()
    .Split(">", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

List<int> warship = Console.ReadLine()
    .Split(">", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

double maxHealth = int.Parse(Console.ReadLine());

string command = string.Empty;

while ((command = Console.ReadLine()) != "Retire")
{
    List<string> currCommand = command.Split().ToList();

    if (currCommand.First() == "Fire")
    {
        int currIndex = int.Parse(currCommand[1]);
        int currDmg = int.Parse(currCommand[2]);

        warship = SubtractDamage(warship, currIndex, currDmg);

        if (warship.Any(x => x <= 0))
        {
            break;
        }
    }
    else if (currCommand.First() == "Defend")
    {
        int startIndex = int.Parse(currCommand[1]);
        int endIndex = int.Parse(currCommand[2]);
        int currDmg = int.Parse(currCommand[3]);

        pirateShip = SubtractEnemyDmg(pirateShip, startIndex, endIndex, currDmg);

        if (pirateShip.Any(x => x <= 0))
        {
            break;
        }
    }
    else if (currCommand.First() == "Repair")
    {
        int currIndex = int.Parse(currCommand[1]);
        int addHealth = int.Parse(currCommand[2]);

        pirateShip = AddHealth(pirateShip, currIndex, addHealth);
    }
    else if (currCommand.First() == "Status")
    {
        PrintSectionsForRepair(pirateShip);
    }
}

if (command == "Retire")
{
    int pirateShipSum = 0;
    int warshipSum = 0;

    for (int i = 0; i < pirateShip.Count; i++)
    {
        pirateShipSum += pirateShip[i];
    }

    for (int i = 0; i < warship.Count; i++)
    {
        warshipSum += warship[i];
    }

    Console.WriteLine($"Pirate ship status: {pirateShipSum}");
    Console.WriteLine($"Warship status: {warshipSum}");
}

void PrintSectionsForRepair(List<int> pirateShip)
{
    int count = 0;

    for (int i = 0; i < pirateShip.Count; i++)
    {
        if ((double)pirateShip[i] < (0.2 * maxHealth))
        {
            count++;
        }
    }

    Console.WriteLine($"{count} sections need repair.");
}

List<int> AddHealth(List<int> pirateShip, int currIndex, int addHealth)
{
    if (currIndex < 0 || currIndex >= pirateShip.Count)
    {
        return pirateShip;
    }

    if (pirateShip[currIndex] + addHealth > maxHealth)
    {
        pirateShip[currIndex] = (int)maxHealth;
    }
    else
    {
        pirateShip[currIndex] += addHealth;
    }

    return pirateShip;
}

List<int> SubtractEnemyDmg(List<int> pirateShip, int startIndex, int endIndex, int currDmg)
{
    if (startIndex < 0 || startIndex >= pirateShip.Count || endIndex < 0 || endIndex >= pirateShip.Count)
    {
        return pirateShip;
    }

    for (int i = startIndex; i <= endIndex; i++)
    {
        pirateShip[i] -= currDmg;

        if (pirateShip[i] <= 0)
        {
            Console.WriteLine("You lost! The pirate ship has sunken.");
            break;
        }
    }

    return pirateShip;
}

List<int> SubtractDamage(List<int> warship, int currIndex, int currDmg)
{
    if (currIndex < 0 || currIndex >= warship.Count)
    {
        return warship;
    }

    warship[currIndex] -= currDmg;

    if (warship[currIndex] <= 0)
    {
        Console.WriteLine("You won! The enemy ship has sunken.");
    }

    return warship;
}
