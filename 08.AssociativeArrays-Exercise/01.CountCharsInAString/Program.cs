
string input = Console.ReadLine();

Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

foreach (char currentChar in input.Where(currentChar => currentChar != ' '))
{
    if (!keyValuePairs.ContainsKey(currentChar))
    {
        keyValuePairs.Add(currentChar, 1);
        continue;
    }

    keyValuePairs[currentChar]++;
}

foreach (var currChar in keyValuePairs)
{
    Console.WriteLine($"{currChar.Key} -> {currChar.Value}");
}