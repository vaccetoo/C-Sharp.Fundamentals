
using System.Text;

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

    int startIndex = int.Parse(currCommand[2]);
    int endIndex = int.Parse(currCommand[3]);

    if (startIndex < 0 || startIndex >= input.Length || endIndex <= startIndex || endIndex > input.Length)
    {
        Console.WriteLine("Invalid indices for Flip instruction.");
        return;
    }

    string substringToChange = input.Substring(startIndex, endIndex - startIndex);

    if (currCommand[1] == "Upper")
    {
        substringToChange = substringToChange.ToUpper();
    }
    else if (currCommand[1] == "Lower")
    {
        substringToChange = substringToChange.ToLower();
    }

    // Replace the substring in the input with the modified one
    StringBuilder modifiedInput = new StringBuilder(input);
    modifiedInput.Remove(startIndex, endIndex - startIndex);
    modifiedInput.Insert(startIndex, substringToChange);

    Console.WriteLine(modifiedInput);
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


