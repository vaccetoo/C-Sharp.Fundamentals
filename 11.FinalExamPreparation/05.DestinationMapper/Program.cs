
using System.Text.RegularExpressions;

string input = Console.ReadLine();

Regex findName = new Regex(@"(\=|\/)((?<name>[A-Z][A-Za-z]{2,}))\1");

MatchCollection matches = findName.Matches(input);

int travelPoints = 0;

List<string> destinations = new List<string>();

foreach (Match match in matches)
{
    destinations.Add(match.Groups["name"].Value);

    travelPoints += int.Parse(match.Groups["name"].Length.ToString());
}

Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
Console.WriteLine($"Travel Points: {travelPoints}");
