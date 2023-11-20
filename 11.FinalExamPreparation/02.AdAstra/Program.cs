
using System.Text.RegularExpressions;

string input = Console.ReadLine();

Regex foodRegex = new Regex
    (@"(\||\#)(?<item>[A-Z][a-z]+(\s[A-Z][a-z]+)?)\1(?<date>\d{2}/\d{2}/\d{2})\1(?<calories>\d+)\1");

MatchCollection matches = foodRegex.Matches (input);

int caloriesSum = 0;

foreach (Match match in matches)
{
    caloriesSum += int.Parse(match.Groups["calories"].Value);
}

int daysToLast = caloriesSum / 2000;

Console.WriteLine($"You have food to last you for: {daysToLast} days!");

foreach (Match match in matches)
{
    Console.WriteLine($"Item: {match.Groups["item"]}, Best before: {match.Groups["date"]}, Nutrition: {match.Groups["calories"]}");
}