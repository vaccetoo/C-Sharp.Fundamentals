
using System.Threading;

string[] dungeonsRooms = Console.ReadLine()
    .Split("|", StringSplitOptions.RemoveEmptyEntries);

int initialHealth = 100;
int bitcoins = 0;

for (int i = 0; i < dungeonsRooms.Length; i++)
{
    string[] currCommand = dungeonsRooms[i].Split();

    if (currCommand.First() == "potion")
    {
        initialHealth = AddHealth(currCommand, initialHealth);
    }
    else if (currCommand.First() == "chest")
    {
        bitcoins = PrintFoundedBitcoins(currCommand, bitcoins);
    }
    else 
    {
        // You have found a monster ...

        initialHealth = SubtracktMonsterDamage(currCommand, initialHealth);

        if (initialHealth <= 0)
        {
            break;
        }
    }
}

if (initialHealth <= 0)
{
    int currBitcoins = 0;
    int mostBitcoins = 0;

    int bestRoom = 0;

    for (int i = 0; i < dungeonsRooms.Length; i++)
    {
        if (dungeonsRooms[i].Split()[0] == "chest")
        {
            currBitcoins = int.Parse(dungeonsRooms[i].Split()[1]);

            if (currBitcoins > mostBitcoins)
            {
                mostBitcoins = currBitcoins;
                bestRoom = i;
            }
        }
    }
    Console.WriteLine($"Best room: {bestRoom}");
}
else
{
    Console.WriteLine("You've made it!");
    Console.WriteLine($"Bitcoins: {bitcoins}");
    Console.WriteLine($"Health: {initialHealth}");
}

int SubtracktMonsterDamage(string[] currCommand, int initialHealth)
{
    if (initialHealth - int.Parse(currCommand[1]) > 0)
    {
        initialHealth -= int.Parse(currCommand[1]);

        Console.WriteLine($"You slayed {currCommand[0]}");
    }
    else
    {
        initialHealth -= int.Parse(currCommand[1]);

        Console.WriteLine($"You died! Killed by {currCommand[0]}.");
    }

    return initialHealth;
}

int PrintFoundedBitcoins(string[] currCommand, int bitcoins)
{
    bitcoins += int.Parse(currCommand[1]);

    Console.WriteLine($"You found {int.Parse(currCommand[1])} bitcoins.");

    return bitcoins;
}

int AddHealth(string[] currCommand, int initialHealth)
{
    if (initialHealth + int.Parse(currCommand[1]) <= 100)
    {
        initialHealth += int.Parse(currCommand[1]);
    }

    Console.WriteLine($"You healed for {int.Parse(currCommand[1])} hp.");
    Console.WriteLine($"Current health: {initialHealth} hp.");

    return initialHealth;
}



