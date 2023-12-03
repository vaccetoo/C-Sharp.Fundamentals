
string input = Console.ReadLine();

string command = string.Empty;

while ((command = Console.ReadLine()) != "End")
{
    string[] commandInfo = command.Split();

    string commandName = commandInfo[0];

    if (commandName == "Translate")
    {
        char charToReplace = char.Parse(commandInfo[1]);
        char newChar = char.Parse(commandInfo[2]);

        input = input.Replace(charToReplace, newChar);

        Console.WriteLine(input);
    }
    else if (commandName == "Includes")
    {
        string substring = commandInfo[1];

        if (input.Contains(substring))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
    else if(commandName == "Start")
    {
        string substring = commandInfo[1];

        if (input.StartsWith(substring))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
    else if (commandName == "Lowercase")
    {
        input = input.ToLower();

        Console.WriteLine(input);
    }
    else if (commandName == "FindIndex")
    {
        char currentChar = char.Parse(commandInfo[1]);

        int lastIndexOfCurrentChar = input.LastIndexOf(currentChar);

        Console.WriteLine(lastIndexOfCurrentChar);
    }
    else if (commandName == "Remove")
    {
        int startIndex = int.Parse(commandInfo[1]);
        int count = int.Parse(commandInfo[2]);

        input = input.Remove(startIndex, count);

        Console.WriteLine(input);
    }
}