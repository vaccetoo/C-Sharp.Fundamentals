
int energy = int.Parse(Console.ReadLine());
int wonBattles = 0;

string command = string.Empty;

while ((command = Console.ReadLine()) != "End of battle")
{

    int distance = int.Parse(command);

    if (energy < distance)
    {
        Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");

        energy -= distance;
        break;
    }

    energy -= distance;
    wonBattles++;

    if (wonBattles % 3 == 0)
    {
        energy += wonBattles;
    }
}

if (energy >= 0)
{
    Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
}