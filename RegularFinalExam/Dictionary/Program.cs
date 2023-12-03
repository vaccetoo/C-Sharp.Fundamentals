
string[] input = Console.ReadLine()
    .Split("|", StringSplitOptions.RemoveEmptyEntries);

Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();

foreach (string pair in input)
{
    string[] wordDefinition = pair.Split(": ", StringSplitOptions.RemoveEmptyEntries);

    string currentWord = wordDefinition[0].Trim();
    string definition = wordDefinition[1];

    if (!keyValuePairs.ContainsKey(currentWord))
    {
        keyValuePairs.Add(currentWord, new List<string>());
    }

    keyValuePairs[currentWord].Add(definition);
}

string[] words = Console.ReadLine()
    .Split(" | ", StringSplitOptions.RemoveEmptyEntries);

string command = Console.ReadLine();

if (command == "Test")
{
    foreach (string word in words)
    {
        if (keyValuePairs.ContainsKey(word))
        {
            foreach (var pair in keyValuePairs)
            {
                if (pair.Key == word)
                {
                    Console.WriteLine($"{pair.Key}:");

                    foreach (var definition in pair.Value)
                    {
                        Console.WriteLine($" -{definition}");
                    }
                }
            }
        }
    }
}
else if (command == "Hand Over")
{
    foreach (var pair in keyValuePairs)
    {
        Console.Write($"{pair.Key} ");
    }
}