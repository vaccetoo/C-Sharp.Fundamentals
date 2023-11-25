
using System.Text.RegularExpressions;

string input = Console.ReadLine();

Regex findWords = new Regex(@"(@|#)(?<firstWord>[A-z]{3,})\1{2}(?<secondWord>[A-z]{3,})\1");

MatchCollection matches = findWords.Matches(input);

List<string> mirrorWords = new List<string>();

if (matches.Count == 0)
{
    Console.WriteLine("No word pairs found!");
}
else
{
    Console.WriteLine($"{matches.Count} word pairs found!");

    foreach (Match match in matches)
    {
        string firstWord = match.Groups["firstWord"].Value;
        string secondWord = match.Groups["secondWord"].Value;
        string reversedSecondWord = new string(match.Groups["secondWord"].Value.Reverse().ToArray());

        if (firstWord == reversedSecondWord)
        {
            mirrorWords.Add($"{firstWord} <=> {secondWord}");
        }
    }
}

if (mirrorWords.Count == 0)
{
    Console.WriteLine("No mirror words!");
}
else
{
    Console.WriteLine("The mirror words are:");
    Console.WriteLine(string.Join(", ", mirrorWords));
}