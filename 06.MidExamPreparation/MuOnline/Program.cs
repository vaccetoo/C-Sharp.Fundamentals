
using System.Threading;

string[] dungeons = Console.ReadLine()
    .Split("|");

int health = 100;
int bitcoins = 0;

int bestRoom = 0;

for (int i = 0; i < dungeons.Length; i++)
{
    string[] command = dungeons[i].Split(" ");

    if (command[0] == "potion")
    {
        health = AddHealth(health, int.Parse(command[1]));
    }
    else if (command[0] == "chest")
    {
        bitcoins = AddBitcoins(bitcoins, int.Parse(command[1]));
    }
    else // You've met the monster
    {
        health = MeetTheMonster(health, command[0], int.Parse(command[1]));

        if (health <= 0)
        {
            bestRoom = i + 1;

            Console.WriteLine($"Best room: {bestRoom}");
            break;
        }
    }
}

if (health > 0)
{
    Console.WriteLine($"You've made it!");
    Console.WriteLine($"Bitcoins: {bitcoins}");
    Console.WriteLine($"Health: {health}");
}

int MeetTheMonster(int health, string monsterName, int monsterDmg)
{
    health -= monsterDmg;

    if (health > 0)
    {
        Console.WriteLine($"You slayed {monsterName}.");
    }
    else
    {
        Console.WriteLine($"You died! Killed by {monsterName}.");
    }

    return health;
}

int AddBitcoins(int bitcoins, int addBitcoins)
{
    bitcoins += addBitcoins;

    Console.WriteLine($"You found {addBitcoins} bitcoins.");

    return bitcoins;
}

int AddHealth(int health, int addHealth)
{
    int currHealth = health;
    health += addHealth;

    if (health > 100)
    {
        addHealth = 100 - currHealth;
        health = 100;
    }

    Console.WriteLine($"You healed for {addHealth} hp.");
    Console.WriteLine($"Current health: {health} hp.");

    return health;
}
     