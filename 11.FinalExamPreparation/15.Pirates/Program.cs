
string input = string.Empty;

List<City> targetCities = new List<City>();

while ((input = Console.ReadLine()) != "Sail")
{
    string[] citiesInfo = input
        .Split("||", StringSplitOptions.RemoveEmptyEntries);

    string cityName = citiesInfo[0];
    int cityPopulation = int.Parse(citiesInfo[1]);
    int cityGold = int.Parse(citiesInfo[2]);

    if (!targetCities.Any(x => x.Name == cityName))
    {
        City currentCity = new City(cityName, cityPopulation, cityGold);

        targetCities.Add(currentCity);
    }
    else
    {
        foreach (var city in targetCities)
        {
            if (city.Name == cityName)
            {
                city.Population += cityPopulation;
                city.Gold += cityGold;
            }
        }
    }
}

string command = string.Empty;

while ((command = Console.ReadLine()) != "End")
{
    string[] commandInfo = command
        .Split("=>", StringSplitOptions.RemoveEmptyEntries);

    string commandName = commandInfo[0];

    if (commandName == "Plunder")
    {
        string cityName = commandInfo[1];
        int peopleCount = int.Parse(commandInfo[2]);
        int goldAmmount = int.Parse(commandInfo[3]);

        foreach (var city in targetCities)
        {
            if (city.Name == cityName)
            {
                city.Population -= peopleCount;
                city.Gold -= goldAmmount;

                Console.WriteLine($"{cityName} plundered! {goldAmmount} gold stolen, {peopleCount} citizens killed.");

                if (city.Population <= 0 || city.Gold <= 0)
                {
                    Console.WriteLine($"{cityName} has been wiped off the map!");
                }
            }
        }
    }
    else if (commandName == "Prosper")
    {
        string cityName = commandInfo[1];
        int goldAmmount = int.Parse(commandInfo[2]);

        if (goldAmmount >= 0)
        {
            foreach (var city in targetCities)
            {
                if (city.Name == cityName)
                {
                    city.Gold += goldAmmount;

                    Console.WriteLine($"{goldAmmount} gold added to the city treasury. {cityName} now has {city.Gold} gold.");
                }
            }
        }
        else
        {
            Console.WriteLine("Gold added cannot be a negative number!");
        }
    }
}

// TODO: Remove all cities with ---> city.Population <= 0 || city.Gold <= 0

targetCities.RemoveAll(x => x.Population <= 0 || x.Gold <= 0);

if (targetCities.Count > 0)
{
    Console.WriteLine($"Ahoy, Captain! There are {targetCities.Count} wealthy settlements to go to:");

    foreach (var city in targetCities)
    {
        Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
    }
}
else
{
    Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
}

public class City
{
    public City(string name, int population, int gold)
    {
        Name = name;
        Population = population;
        Gold = gold;
    }

    public string Name { get; set; }

    public int Population { get; set; }

    public int Gold { get; set; }   
}