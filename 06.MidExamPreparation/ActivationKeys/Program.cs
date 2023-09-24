
string input = Console.ReadLine();  

string command = string.Empty;

while ((command = Console.ReadLine()) != "Generate")
{
    List<string> currCommand = command
        .Split(">>>", StringSplitOptions.RemoveEmptyEntries)
        .ToList();

    if (currCommand.First() == "Contains")
    {
        DoesInputContainsSubstring(input, currCommand);
    }
    else if (currCommand.First() == "Flip")
    {
        FlipIndexes(input, currCommand);
    }
    else if (currCommand.First() == "Slice")
    {
        // "Slice>>>{startIndex}>>>{endIndex}":
        // Deletes the characters between the start and end indices (the end index is exclusive) and prints the activation key.

        SliceIndexes(input, currCommand);
    }
}

Console.WriteLine($"Your activation key is: ");

void SliceIndexes(string input, List<string> currCommand)
{
    
}

void FlipIndexes(string input, List<string> currCommand)
{
    // "Flip>>>Upper/Lower>>>{startIndex}>>>{endIndex}":
    // Changes the substring between the given indices (the end index is exclusive) to upper or lower case and then prints the activation key.

    if (currCommand[1] == "Upper")
    {
        
    }
    else if (currCommand[1] == "Lower")
    {
        
    }
}

void DoesInputContainsSubstring(string input, List<string> currCommand)
{
    // Contains>>>{substring}":
    // If the raw activation key contains the given substring, prints: "{raw activation key} contains {substring}". Otherwise, prints: "Substring not found!"

    if (input.Contains(currCommand[1]))
    {
        Console.WriteLine($"{input} contains {currCommand[1]}");
    }
    else
    {
        Console.WriteLine("Substring not found!");
    }
}

