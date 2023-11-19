
using System.Text.RegularExpressions;

string command = string.Empty;

List<Match> matches = new List<Match>();    

while ((command = Console.ReadLine()) != "end of shift")
{
    Regex orderInfo = new Regex(@"\%(?<customer>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)\$");

    Match currunMatch = orderInfo.Match(command);

    if (currunMatch.Success)
    {
        matches.Add(currunMatch);
    }
}

decimal totalIncome = 0;

foreach (Match match in matches)
{
    int count = int.Parse(match.Groups["count"].Value);
    decimal price = decimal.Parse(match.Groups["price"].Value);

    decimal totalPrice = count * price;

    totalIncome += totalPrice;

    Console.WriteLine($"{match.Groups["customer"]}: {match.Groups["product"]} - {totalPrice:f2}");
}

Console.WriteLine($"Total income: {totalIncome:f2}");