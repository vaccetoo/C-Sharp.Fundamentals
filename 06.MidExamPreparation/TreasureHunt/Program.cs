
List<string> chest = Console.ReadLine()
    .Split("|", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string command = string.Empty;

while ((command = Console.ReadLine()) != "Yohoho!")
{
    string[] commandAsArray = command.Split().ToArray();

    string currCommand = commandAsArray[0];

    if (currCommand == "Loot")
    {
        chest = InsertItems(chest, commandAsArray);
    }
    else if (currCommand == "Drop")
    {
        int index = int.Parse(commandAsArray[1]);

        chest = PlaceTheLootAtTheEnd(chest, index);
    }
    else if (currCommand == "Steal")
    {
        int count = int.Parse(commandAsArray[1]);

        chest = RemoveStolenItems(chest, count);
    }
}

if (chest.Count <= 0)
{
    Console.WriteLine("Failed treasure hunt.");
}
else
{
    double sum = 0;

    for (int i = 0; i < chest.Count; i++)
    {
        sum += chest[i].Length;
    }

    double averageProfit = sum / chest.Count;

    Console.WriteLine($"Average treasure gain: {averageProfit:f2} pirate credits.");
}

List<string> RemoveStolenItems(List<string> chest, int count)
{
    if (count >= chest.Count)
    {
        count = chest.Count;
    }

    List<string> stolenItems = new List<string>();

    for (int i = chest.Count - count; i < chest.Count; i++)
    {
        stolenItems.Add(chest[i]);
    }

    chest.RemoveRange(chest.Count - count, count);

    Console.WriteLine(string.Join(", ", stolenItems));

    return chest;
}

List<string> PlaceTheLootAtTheEnd(List<string> chest, int index)
{
    if (index >= 0 && index < chest.Count)
    {
        chest.Add(chest[index]);
        chest.RemoveAt(index);
    }

    return chest;
}

List<string> InsertItems(List<string> chest, string[] commandAsArray)
{
    for (int i = 1; i < commandAsArray.Length; i++)
    {
        string item = commandAsArray[i];

        if (!chest.Contains(item))
        {
            chest.Insert(0, item);
        }
    }

    return chest;
}
