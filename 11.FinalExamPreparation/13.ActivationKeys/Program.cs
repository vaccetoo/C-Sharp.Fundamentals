
using System;

string activationKey = Console.ReadLine();

string command = string.Empty;

while ((command = Console.ReadLine()) != "Generate")
{
    string[] commandInfo = command
        .Split(">>>", StringSplitOptions.RemoveEmptyEntries);

    string commandName = commandInfo[0];

    if (commandName == "Contains")
    {
        string substring = commandInfo[1];

        if (activationKey.Contains(substring))
        {
            Console.WriteLine($"{activationKey} contains {substring}");
        }
        else
        {
            Console.WriteLine("Substring not found!");
        }
    }
    else if (commandName == "Flip")
    {
        string flippCase = commandInfo[1];
        int startIndex = int.Parse(commandInfo[2]);
        int endIndex = int.Parse(commandInfo[3]);

        if (flippCase == "Upper")
        {
            string substring = activationKey.Substring(startIndex, endIndex - startIndex);

            activationKey = activationKey.Replace(substring, substring.ToUpper());
        }
        else if(flippCase == "Lower")
        {
            string substring = activationKey.Substring(startIndex, endIndex - startIndex);

            activationKey = activationKey.Replace(substring, substring.ToLower());
        }

        Console.WriteLine(activationKey);
    }
    else if (commandName == "Slice")
    {
        int startIndex = int.Parse(commandInfo[1]);
        int endIndex = int.Parse(commandInfo[2]);

        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
        Console.WriteLine(activationKey);
    }
}

Console.WriteLine($"Your activation key is: {activationKey}");