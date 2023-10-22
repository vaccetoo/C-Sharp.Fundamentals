
List<string> route = Console.ReadLine()
    .Split("||", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

int fuelAmount = int.Parse(Console.ReadLine());
int amunitionsAmount = int.Parse(Console.ReadLine());

for (int i = 0; i < route.Count; i++)
{
    List<string> command = route[i].Split().ToList();

    string currCommand = command[0];

    if (currCommand == "Travel")
    {
        int distance = int.Parse(command[1]);

        fuelAmount -= distance;

        if (fuelAmount >= 0)
        {
            Console.WriteLine($"The spaceship travelled {distance} light-years.");
        }
        else
        {
            Console.WriteLine($"Mission failed.");

            break;
        }
    }
    else if (currCommand == "Enemy")
    {
        int enemyArmor = int.Parse(command[1]);

        if (amunitionsAmount >= enemyArmor)
        {
            amunitionsAmount -= enemyArmor;

            Console.WriteLine($"An enemy with {enemyArmor} armour is defeated.");
        }
        else
        {
            fuelAmount -= enemyArmor * 2;

            if (fuelAmount >= 0)
            {
                Console.WriteLine($"An enemy with {enemyArmor} armour is outmaneuvered.");
            }
            else
            {
                Console.WriteLine($"Mission failed.");

                break;
            }
        }
    }
    else if (currCommand == "Repair")
    {
        int addFuel = int.Parse(command[1]);

        int addAmmunitions = addFuel * 2;

        fuelAmount += addFuel;
        amunitionsAmount += addAmmunitions;

        Console.WriteLine($"Ammunitions added: {addAmmunitions}.");
        Console.WriteLine($"Fuel added: {addFuel}.");
    }
    else if (currCommand == "Titan")
    {
        Console.WriteLine("You have reached Titan, all passengers are safe.");
        break;
    }
}