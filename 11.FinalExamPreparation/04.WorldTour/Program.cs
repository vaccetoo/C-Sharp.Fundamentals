
string stops = Console.ReadLine();

string command = string.Empty;

while ((command = Console.ReadLine()) != "Travel")
{
    string[] commandInfo = command.Split(":");

    string commandName = commandInfo[0];

    if (commandName == "Add Stop")
    {
        int index = int.Parse(commandInfo[1]);
        string stringToInsert = commandInfo[2];

        if (index < stops.Length)
        {
            stops = stops.Insert(index, stringToInsert);
            Console.WriteLine(stops);
        }
        else
        {
            Console.WriteLine(stops);
            continue;
        }
    }
    else if (commandName == "Remove Stop")
    {
        int startIndex = int.Parse(commandInfo[1]);
        int endIndex = int.Parse(commandInfo[2]);

        if (startIndex >= 0 && endIndex < stops.Length)
        {
            stops = stops.Remove(startIndex, endIndex - startIndex + 1);
            Console.WriteLine(stops);
        }
        else
        {
            Console.WriteLine(stops);
            continue;
        }
    }
    else if (commandName == "Switch")
    {
        string oldString = commandInfo[1];
        string newString = commandInfo[2];

        if (stops.Contains(oldString))
        {
            stops = stops.Replace(oldString, newString);
            Console.WriteLine(stops);
        }
        else
        {
            Console.WriteLine(stops);
            continue;
        }
    }
}

Console.WriteLine($"Ready for world tour! Planned stops: {stops}");