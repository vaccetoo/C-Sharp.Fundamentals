
using System.Text.RegularExpressions;

Regex captureFurnitures = new Regex(@">>(?<name>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)");

string command = String.Empty;

List<Match> matches = new List<Match>();

decimal totalPrice = 0;

while ((command = Console.ReadLine()) != "Purchase")
{
    Match match = captureFurnitures.Match(command);

    if (match.Success)
    {
        matches.Add(match);

        string name = match.Groups["name"].Value;
        decimal price = decimal.Parse(match.Groups["price"].Value);
        int quantity = int.Parse(match.Groups["quantity"].Value);

        decimal currentSum = price * quantity;

        totalPrice += currentSum;
    }
}

Console.WriteLine($"Bought furniture:");

foreach (Match match in matches)
{
    Console.WriteLine(match.Groups["name"].Value);
}

Console.WriteLine($"Total money spend: {totalPrice:f2}");
