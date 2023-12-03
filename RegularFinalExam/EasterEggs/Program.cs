
using System.Drawing;
using System.Text.RegularExpressions;

string hiddenEggs = Console.ReadLine();

Regex findTheEggs = new Regex(@"(\@{1,}(\#{1,})?|\#{1,}(\@{1,})?)(?<color>[a-z]{3,})(\@{1,}|\#{1,})((/D+|\W+)?)\/{1,}(?<amount>\d+)\/{1,}");

MatchCollection mathes = findTheEggs.Matches(hiddenEggs);

foreach (Match match in mathes)
{
    Console.WriteLine($"You found {match.Groups["amount"].Value} {match.Groups["color"].Value} eggs!");
}