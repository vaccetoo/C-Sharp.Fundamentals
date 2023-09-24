
string rawActivationKey = Console.ReadLine();

string command = string.Empty;

while ((command = Console.ReadLine()) != "Generate")
{
    List<string> currCommand = command.Split(">>>").ToList();

    if (currCommand.First() == "Contains")
    {
        DoesContainTheSubstring(rawActivationKey, currCommand);
    }
    else if (currCommand.First() == "Flip")
    {
        rawActivationKey = FlipIndexes(rawActivationKey, currCommand);
    }
    else if (currCommand.First() == "Slice")
    {
        rawActivationKey = SliceBetweenIndexes(rawActivationKey, currCommand);
    }
}

Console.WriteLine($"Your activation key is: {rawActivationKey}");

string SliceBetweenIndexes(string rawActivationKey, List<string> currCommand)
{
    int startIndex = int.Parse(currCommand[1]);
    int endIndex = int.Parse(currCommand[2]);

    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);

    Console.WriteLine(rawActivationKey);

    return rawActivationKey;
}

string FlipIndexes(string rawActivationKey, List<string> currCommand)
{
    int startIndex = int.Parse(currCommand[2]);
    int endIndex = int.Parse(currCommand[3]);

    if (currCommand[1] == "Upper")
    {
        string substring = rawActivationKey.Substring(startIndex, endIndex - startIndex);

        rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);
        rawActivationKey = rawActivationKey.Insert(startIndex, substring.ToUpper());
    }
    else if (currCommand[1] == "Lower")
    {
        string substring = rawActivationKey.Substring(startIndex, endIndex - startIndex);

        rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);
        rawActivationKey = rawActivationKey.Insert(startIndex, substring.ToLower());
    }

    Console.WriteLine(rawActivationKey);

    return rawActivationKey;
}

void DoesContainTheSubstring(string rawActivationKey, List<string> currCommand)
{
    string substring = currCommand[1];

    if (rawActivationKey.Contains(substring))
    {
        Console.WriteLine($"{rawActivationKey} contains {substring}");
    }
    else
    {
        Console.WriteLine("Substring not found!");
    }
}
 