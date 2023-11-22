
int plantsCount = int.Parse(Console.ReadLine());

Dictionary<string, int> plantRarity = new Dictionary<string, int>();

for (int i = 0; i < plantsCount; i++)
{
    string[] plantInfo = Console.ReadLine()
        .Split("<->");

    string name = plantInfo[0];
    int rarity = int.Parse(plantInfo[1]);

    if (!plantRarity.ContainsKey(name))
    {
        plantRarity.Add(name, rarity);
        continue;
    }

    plantRarity[name] = rarity;
}

string command = string.Empty;

Dictionary<string, List<double>> plantRating = new Dictionary<string, List<double>>();

foreach (var plant in plantRarity)
{
    plantRating.Add(plant.Key, new List<double>());
}

while ((command = Console.ReadLine()) != "Exhibition")
{
    string[] commandInfo = command
        .Split(':', '-');

    string commandName = commandInfo[0];
    string plantName = commandInfo[1].Trim();

    if (!plantRarity.ContainsKey(plantName))
    {
        Console.WriteLine("error");
        continue;
    }

    if (commandName == "Rate")
    {
        double rating = double.Parse(commandInfo[2]);

        plantRating[plantName].Add(rating);
    }
    else if (commandName == "Update")
    {
        int newRarity = int.Parse(commandInfo[2]);

        plantRarity[plantName] = newRarity;
    }
    else if (commandName == "Reset")
    {
        plantRating[plantName].Clear();
    }
}

Console.WriteLine("Plants for the exhibition:");

foreach (var plant in plantRating)
{
    double sumRating = plant.Value.Sum();
    double averegeSum = plant.Value.Count > 0 ? sumRating / plant.Value.Count : 0.0;

    Console.WriteLine($"- {plant.Key}; Rarity: {plantRarity[plant.Key]}; Rating: {averegeSum:f2}");
}