
using System.Text.RegularExpressions;

string input = Console.ReadLine();

Regex regex = new Regex(@"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1");

MatchCollection matches = regex.Matches(input);

int coolThresholdSum = 1;

for (int i = 0; i < input.Length; i++)
{
    if (char.IsDigit(input[i]))
    {
        coolThresholdSum *= int.Parse(input[i].ToString());
    }
}

Console.WriteLine($"Cool threshold: {coolThresholdSum}");
Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

List<Match> coolestEmojies = new List<Match>();

foreach (Match match in matches)
{
    int currentEmojiCoolness = 1;

    string currentEmojiAsString = match.Groups["emoji"].Value;

    for (int i = 0; i < currentEmojiAsString.Length; i++)
    {
        currentEmojiCoolness += currentEmojiAsString[i];
    }

    if (currentEmojiCoolness >= coolThresholdSum)
    {
        coolestEmojies.Add(match);
    }
}

Console.WriteLine(string.Join(Environment.NewLine, coolestEmojies));

