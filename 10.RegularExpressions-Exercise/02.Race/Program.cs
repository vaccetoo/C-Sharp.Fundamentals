
using System.Text;
using System.Text.RegularExpressions;

List<string> racers = Console.ReadLine()
    .Split(", ")
    .ToList();

string command = string.Empty;

Dictionary<string, int> participants = new Dictionary<string, int>();

while ((command = Console.ReadLine()) != "end of race")
{

    MatchCollection matchedNames = Regex.Matches(command, @"([A-Za-z]+)");
    MatchCollection matchedDistance = Regex.Matches(command, @"(\d)");

    string name = string.Join("", matchedNames);
    int distance = matchedDistance.Select(x => int.Parse(x.Value)).Sum();

    if (racers.Contains(name))
    {
        if (!participants.ContainsKey(name))
        {
            participants.Add(name, distance);
        }
        else
        {
            participants[name] += distance;
        }
    }
}

int counter = 1;

foreach (var person in participants.OrderByDescending(x => x.Value).Take(3))
{
    if (counter == 1)
    {
        Console.WriteLine($"1st place: {person.Key}");
    }
    else if (counter == 2)
    {
        Console.WriteLine($"2nd place: {person.Key}");
    }
    else
    {
        Console.WriteLine($"3rd place: {person.Key}");
    }

    counter++;
}
